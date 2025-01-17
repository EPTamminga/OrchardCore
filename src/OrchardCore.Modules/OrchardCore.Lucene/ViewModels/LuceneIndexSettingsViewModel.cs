using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OrchardCore.Lucene.ViewModels
{
    public class LuceneIndexSettingsViewModel
    {
        public string IndexName { get; set; }

        public string AnalyzerName { get; set; }

        public bool IndexLatest { get; set; }

        public bool IndexInBackgroundTask { get; set; }

        public string[] IndexedContentTypes { get; set; }

        #region List to populate
        [BindNever]
        public IEnumerable<SelectListItem> Analyzers { get; set; }
        #endregion
    }
}
