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
using System.Security.Policy;
using System.Text;

namespace Coffee_nhomChungMinh.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Hoadon : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Hoadon(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        private DateTime _Ngay;
        [XafDisplayName("Ngày")]
        public DateTime Ngay
        {
            get { return _Ngay; }
            set { SetPropertyValue<DateTime>(nameof(Ngay), ref _Ngay, value); }
        }


        private int _Soban;
        [XafDisplayName("Số bàn")]
        public int Soban
        {
            get { return _Soban; }
            set { SetPropertyValue<int>(nameof(Soban), ref _Soban, value); }
        }



        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<Khachhang> Khachhangs
        {
            get { return GetCollection<Khachhang>(nameof(Khachhangs)); }
        }





        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<Thungan> Thungans
        {
            get { return GetCollection<Thungan>(nameof(Thungans)); }
        }






    }
}