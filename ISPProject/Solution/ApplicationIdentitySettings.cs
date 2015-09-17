namespace ISPProject.Solution
{
    public class ApplicationIdentitySettings : IApplicationIdentitySettings
    {
        private readonly string _applicationName;
        private readonly string _authorName;

        public ApplicationIdentitySettings(IConfigurationSettings config)
        {
            _authorName = config.AuthorName;
            _applicationName = config.ApplicationName;
        }

        public string ApplicationName
        {
            get { return _applicationName; }
        }

        public string AuthorName
        {
            get { return _authorName; }
        }
    }
}