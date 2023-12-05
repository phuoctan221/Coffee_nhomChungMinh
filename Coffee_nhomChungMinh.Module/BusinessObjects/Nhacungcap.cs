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

namespace Coffee_nhomChungMinh.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Nhacungcap : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Nhacungcap(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<Phieuchi> Phieuchis
        {
            get { return GetCollection<Phieuchi>(nameof(Phieuchis)); }
        }


        private string _TenNCC;
        [XafDisplayName("Tên nhà cung cấp"),Size(255)]
        public string TenNCC
        {
            get { return _TenNCC; }
            set { SetPropertyValue<string>(nameof(TenNCC), ref _TenNCC, value); }
        }


        private string _Phone;
        [XafDisplayName("Phone"),Size(30)]
        public string Phone
        {
            get { return _Phone; }
            set { SetPropertyValue<string>(nameof(Phone), ref _Phone, value); }
        }


        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<Phieunhap> Phieunhaps
        {
            get { return GetCollection<Phieunhap>(nameof(Phieunhaps)); }
        }









    }
}