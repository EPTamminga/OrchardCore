using System.Collections.Generic;
using Lucene.Net.Util;

namespace OrchardCore.Lucene.Model
{
    public class LuceneSettings
    {
        public static string StandardAnalyzer = "standardanalyzer";

        public static LuceneVersion DefaultVersion = LuceneVersion.LUCENE_48;

        public string SearchIndex { get; set; }

        public string[] DefaultSearchFields { get; set; } = new string[0];

        /// <summary>
        /// Gets the list of indices and their settings.
        /// </summary>
        public Dictionary<string, LuceneIndexSettings> IndexSettings { get; } = new Dictionary<string, LuceneIndexSettings>();
    }
}
