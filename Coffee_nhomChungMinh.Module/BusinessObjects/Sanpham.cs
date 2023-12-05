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
    public class Sanpham : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Sanpham(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        

        private string _TenSP;
        [XafDisplayName("Tên SP")]
        public string TenSP
        {
            get { return _TenSP; }
            set { SetPropertyValue<string>(nameof(TenSP), ref _TenSP, value); }
        }


        private string _Dvt;
        [XafDisplayName("ĐVT"),Size(10)]
        public string Dvt
        {
            get { return _Dvt; }
            set { SetPropertyValue<string>(nameof(Dvt), ref _Dvt, value); }
        }


        private string _Size;
        [XafDisplayName("Size")]
        public string Size
        {
            get { return _Size; }
            set { SetPropertyValue<string>(nameof(Size), ref _Size, value); }
        }


        private decimal _Giaban;
        [XafDisplayName("Giá bán")]
        public decimal Giaban
        {
            get { return _Giaban; }
            set { SetPropertyValue<decimal>(nameof(Giaban), ref _Giaban, value); }
        }



        private NhomSP _Nhom;
        [XafDisplayName("Nhóm")]
        [Association]
        public NhomSP Nhom
        {
            get { return _Nhom; }
            set { SetPropertyValue<NhomSP>(nameof(Nhom), ref _Nhom, value); }
        }


        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<Dinhluong> Dinhluongs
        {
            get { return GetCollection<Dinhluong>(nameof(Dinhluongs)); }
        }


        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<HoadonCT> HoadonCTs
        {
            get { return GetCollection<HoadonCT>(nameof(HoadonCTs)); }
        }


        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<PhieuxuatCT> PhieuxuatCTs
        {
            get { return GetCollection<PhieuxuatCT>(nameof(PhieuxuatCTs)); }
        }

        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<PhieunhapCT> PhieunhapCTs
        {
            get { return GetCollection<PhieunhapCT>(nameof(PhieunhapCTs)); }
        }



    }
}