using System.IO;

namespace ISPProject.Solution
{
    public class AboutPage
    {
        private readonly IApplicationIdentitySettings _applicationIdentitySettings;

        public AboutPage(IApplicationIdentitySettings applicationIdentitySettings)
        {
            _applicationIdentitySettings = applicationIdentitySettings;
        }

        public AboutPage(IConfigurationSettings configurationSettings)
        {
            _applicationIdentitySettings = new ApplicationIdentitySettings(configurationSettings);
        }

        public AboutPage()
            : this(ConfigurationSettings.Settings)
        { }

        public void Render(TextWriter writer)
        {
            writer.Write("{0} By {1}",
                _applicationIdentitySettings.ApplicationName,
                _applicationIdentitySettings.AuthorName);
        }
    }
}