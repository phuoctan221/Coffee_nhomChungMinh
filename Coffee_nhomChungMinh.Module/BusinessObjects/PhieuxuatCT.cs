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
    public class PhieuxuatCT : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public PhieuxuatCT(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private Phieuxuat _Phieuxuat;
        [Association]
        public Phieuxuat Phieuxuat
        {
            get { return _Phieuxuat; }
            set { SetPropertyValue<Phieuxuat>(nameof(Phieuxuat), ref _Phieuxuat, value); }
        }


        private Sanpham _Sanpham;
        [Association]
        public Sanpham Sanpham
        {
            get { return _Sanpham; }
            set { SetPropertyValue<Sanpham>(nameof(Sanpham), ref _Sanpham, value); }
        }



        private double _Soluong;
        [XafDisplayName("Số lượng")]
        public double Soluong
        {
            get { return _Soluong; }
            set { SetPropertyValue<double>(nameof(Soluong), ref _Soluong, value); }
        }


        private decimal _Dongia;
        []
        public decimal Dongia
        {
            get { return _Dongia; }
            set { SetPropertyValue<decimal>(nameof(Dongia), ref _Dongia, value); }
        }










    }
}