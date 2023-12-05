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
    public class Nhanvien : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Nhanvien(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _Hoten;
        [XafDisplayName("Họ tên"),Size(30)]
        public string Hoten
        {
            get { return _Hoten; }
            set { SetPropertyValue<string>(nameof(Hoten), ref _Hoten, value); }
        }


        private string _phone;
        [XafDisplayName("Phone"),Size(30)]
        public string phone
        {
            get { return _phone; }
            set { SetPropertyValue<string>(nameof(phone), ref _phone, value); }
        }


        private string _Congviec;
        [XafDisplayName("Công việc")]
        public string Congviec
        {
            get { return _Congviec; }
            set { SetPropertyValue<string>(nameof(Congviec), ref _Congviec, value); }
        }



        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<Phieuchi> Phieuchis
        {
            get { return GetCollection<Phieuchi>(nameof(Phieuchis)); }
        }



        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<Phieuthu> Phieuthus
        {
            get { return GetCollection<Phieuthu>(nameof(Phieuthus)); }
        }


        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<Chamcong> Chamcongs
        {
            get { return GetCollection<Chamcong>(nameof(Chamcongs)); }
        }


        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<Phieuxuat> Phieuxuats
        {
            get { return GetCollection<Phieuxuat>(nameof(Phieuxuats)); }
        }

    }
}