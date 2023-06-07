using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper
{
    public class Issue
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Article> Articles { get; set; }


        public int ArticleCount(NewspaperContext context)
        {
            var articleList = context.Articles.Where(article => article.Issue.Id == Id);
            return articleList.Count();
        }
        public int ReporterCount(NewspaperContext context)
        {
            var articleList = context.Articles.Where(article => article.Issue.Id == Id);
            var reporterList = articleList.Select(a => a.Reporter).ToList();
            return reporterList.Distinct().Count();
        }
        public List<string> ReporterNames(NewspaperContext context)
        {

            var articleList = context.Articles.Where(article => article.Issue.Id == Id);
            List<string> reporterNameList = articleList.Select(a => a.Reporter.Name).ToList();
            List<string> uniqueReporterList = reporterNameList.Distinct();
            return uniqueReporterList;
        }
    }
}
