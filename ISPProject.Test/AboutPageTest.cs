using System.IO;
using NUnit.Framework;

namespace ISPProject
{
    [TestFixture]
    public class AboutPageShould
    {
        [Test]
        public void DisplayApplicationName()
        {
            var aboutPage = new AboutPage(); // -- hard to TEST!  Need app.config set up just so.
            var textWriter = new StringWriter();
            aboutPage.Render(textWriter);

            var output = textWriter.ToString();

            Assert.AreEqual("Interface Segregation By Steve Smith", output);
        }
    }
}