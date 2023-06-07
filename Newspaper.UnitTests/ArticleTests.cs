using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper.UnitTests
{
    public class ArticleTests
    {
        [Fact]
        public void Article_Constructor_CreatesArticleObject()
        {
            var reporterTest = new Reporter();
            var issueTest = new Issue();
            var articleTest = new Article()
            {
                Id = 1,
                Title = "Test Title",
                Content = "Test Content",
                Reporter = reporterTest,
                Issue = issueTest
            };

            Assert.Equal(1, articleTest.Id);
            Assert.Equal("Test Title", articleTest.Title);
            Assert.Equal("Test Content", articleTest.Content);
            Assert.Equal(reporterTest, articleTest.Reporter);
            Assert.Equal(issueTest, articleTest.Issue);
        }
    }
}
