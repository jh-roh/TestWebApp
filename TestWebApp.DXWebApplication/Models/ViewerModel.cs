using DevExpress.XtraReports.Web.WebDocumentViewer;

namespace TestWebApp.DXWebApplication.Models {
    public class ViewerModel {
        public string ReportUrl { get; set; }
        public WebDocumentViewerModel ViewerModelToBind { get; set; }
    }
}