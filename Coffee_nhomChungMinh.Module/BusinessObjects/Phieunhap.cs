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
    public class Phieunhap : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Phieunhap(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private DateTime _Ngay;
        public DateTime Ngay
        {
            get { return _Ngay; }
            set { SetPropertyValue<DateTime>(nameof(Ngay), ref _Ngay, value); }
        }




        private Nhacungcap _NCC;
        [Association]
        public Nhacungcap NCC
        {
            get { return _NCC; }
            set { SetPropertyValue<Nhacungcap>(nameof(NCC), ref _NCC, value); }
        }



        private Nhanvien _Nhanvien;
        [Association]
        public Nhanvien Nhanvien
        {
            get { return _Nhanvien; }
            set { SetPropertyValue<Nhanvien>(nameof(Nhanvien), ref _Nhanvien, value); }
        }






        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<PhieunhapCT> PhieunhapCTs
        {
            get { return GetCollection<PhieunhapCT>(nameof(PhieunhapCTs)); }
        }











    }
}