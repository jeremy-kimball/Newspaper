namespace Newspaper.UnitTests
{
    public class ReporterTests
    {
        [Fact]
        public void Test1()
        {
            var reporterTest = new Reporter()
            {
                Id = 1,
                Name = "Test Name",
                Specialty = "Test Specialty",
                Articles = new List<Article>()
            };

            Assert.Equal(1, reporterTest.Id);
            Assert.Equal("Test Name", reporterTest.Name);
            Assert.Equal("Test Specialty", reporterTest.Specialty);
            Assert.Equal(new List<Article>(), reporterTest.Articles);

        }
    }
}