using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DXApplication1.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    [System.ComponentModel.DisplayName("Nhóm thực đơn")]
    [DefaultProperty("Tennhom")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class NhomSP : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public NhomSP(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _Tennhom;
        [XafDisplayName("Tên nhóm"), Size(30)]
        public string Tennhom
        {
            get { return _Tennhom; }
            set { SetPropertyValue<string>(nameof(Tennhom), ref _Tennhom, value); }
        }

        [DevExpress.Xpo.Aggregated, Association]
        [XafDisplayName("Thực đơn trong nhóm")]
        public XPCollection<Sanpham> Sanphams
        {
            get { return GetCollection<Sanpham>(nameof(Sanphams)); }
        }


    }
}