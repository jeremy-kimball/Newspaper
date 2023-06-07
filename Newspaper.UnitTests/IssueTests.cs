using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newspaper;

namespace Newspaper.UnitTests
{
    public class IssueTests
    {
        [Fact]
        public void Issue_Constructor_CreatesIssueObject()
        {
            var issueTest = new Issue()
            {
                Id = 1,
                Date = DateTime.Today,
                Articles = new List<Article>()
            };

            Assert.Equal(1, issueTest.Id);
            Assert.Equal(DateTime.Today, issueTest.Date);
            Assert.Equal(new List<Article>(), issueTest.Articles);

        }
    }
}
