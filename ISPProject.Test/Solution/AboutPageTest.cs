using System.IO;
using NUnit.Framework;

namespace ISPProject.Solution
{
    [TestFixture]
    public class AboutPageShould
    {
        [Test]
        public void DisplayApplicationNameNoFile()
        {
            // now works without file
            var aboutPage = new AboutPage(new Settings());
            var textWriter = new StringWriter();
            aboutPage.Render(textWriter);

            var output = textWriter.ToString();

            Assert.AreEqual("TEST APP NAME By TEST AUTHOR NAME", output);
        }

        #region This should be kept otherwise we are chaning the application -> ReFucktoring

        [Test]
        public void DisplayApplicationNameFromFile()
        {
            // TODO: Fix
            //still works via file
            var aboutPage = new AboutPage(); // -- hard to TEST!  Need app.config set up just so.
            var textWriter = new StringWriter();
            aboutPage.Render(textWriter);

            var output = textWriter.ToString();

            Assert.AreEqual("Interface Segregation By Steve Smith", output);
        }

        #endregion


        class Settings : IApplicationIdentitySettings
        {
            public string ApplicationName
            {
                get { return "TEST APP NAME"; }
            }

            public string AuthorName
            {
                get { return "TEST AUTHOR NAME"; }
            }
        }

        
    }
}