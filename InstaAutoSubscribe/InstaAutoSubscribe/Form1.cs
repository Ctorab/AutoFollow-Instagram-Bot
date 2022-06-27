using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using InstaSharper.Logger;

namespace InstaAutoSubscribe
{
    public partial class Form1 : Form
    {
        private string _accountName => AccLink.Text;
        private UserSessionData _user = UserSessionData.Empty;
        private IInstaApi _api = null;

        private List<InstaUserShort> _targetPageFollowers = new(0);
        private List<InstaUserShort> _currentUserFollowings = new(0);
        private bool _loggedIn = false;

        private int _followLimit => int.TryParse(FollowersLimit.Text, out var limit) ? limit : -1;
        private int _pullFollowersLimit => int.TryParse(PullFolowers.Text, out var limit) ? limit / 100 : 1;

        public Form1() => InitializeComponent();

        #region Buttons_Click
        private async void RefreshBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_accountName))
            {
                MessageBox.Show("Please Enter Account Link!");
                return;
            }

            if (!_loggedIn)
            {
                MessageBox.Show("You are Logged Out.Log In and try again");
                return;
            }

            await PullUserFollowers(_accountName);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Incorrect password or username!");
                return;
            }

            await InitInstagram();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (!_loggedIn || _targetPageFollowers.Count == 0)
            {
                MessageBox.Show("Error!Please make sure that you pulled followers and logged in");
                return;
            }

            await FollowUsers();
        }
        #endregion

        private async Task InitInstagram()
        {
            _user = new();
            _user.UserName = UserName.Text;
            _user.Password = Password.Text;

            await Login();
        }

        private async Task Login()
        {
            _api = InstaApiBuilder.CreateBuilder()
                .SetUser(_user)
                .UseLogger(new DebugLogger(LogLevel.Exceptions))
                .SetRequestDelay(RequestDelay.FromSeconds(8, 8))
                .Build();

            var loginRequest = await _api.LoginAsync();
            bool loginSucceeded = loginRequest.Succeeded;

            if (!loginSucceeded)
            {
                MessageBox.Show("Failed To Log In " + loginRequest.Info.Message);
                return;
            }

            await PullCurrentUserFollowings();

            MessageBox.Show("Logged In!");

            LogStatusLable.Text = loginSucceeded ? "Logged In" : "Logged Out";
            _loggedIn = loginSucceeded;
        }

        private async Task PullCurrentUserFollowings()
        {
            var followings = await _api.GetUserFollowingAsync(UserName.Text, PaginationParameters.Empty);
            _currentUserFollowings = followings.Value.ToList();
        }

        private async Task PullUserFollowers(string username)
        {
            var followers = await _api.GetUserFollowersAsync(username, PaginationParameters.MaxPagesToLoad(_pullFollowersLimit == 0 ? 1 : _pullFollowersLimit));

            var followerAccounts = followers.Value.Where(follower => !_currentUserFollowings.Contains(follower) && follower.UserName != _user.UserName).ToList();
            _targetPageFollowers = followerAccounts;

            Users.Items.Clear();
            for (int i = 0; i < _targetPageFollowers.Count; i++)
            {
                Users.Items.Add(_targetPageFollowers[i].UserName);               
            }

            MessageBox.Show($"Pulled {followerAccounts.Count} followers");
        }

        private async Task FollowUsers()
        {
            if (_followLimit > _targetPageFollowers.Count)
            {
                MessageBox.Show($"User does not have {_followLimit} followers.Try to enter smaller number.User current followers count {_targetPageFollowers.Count}");
                return;
            }

            for (int i = 0; i < _followLimit; i++)
            {
                await _api.FollowUserAsync(_targetPageFollowers[i].Pk);
                _currentUserFollowings.Add(_targetPageFollowers[i]);

                Thread.Sleep(int.TryParse(Delay.Text, out int delay) ? delay : 1000);
            }

            MessageBox.Show("Finished following!");
        }
    }
}