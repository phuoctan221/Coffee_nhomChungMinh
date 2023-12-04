using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace DXApplication1.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("Phieu")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class HoadonCT : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public HoadonCT(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        private Hoadon _Phieu;
        [XafDisplayName("Phiếu")]
        [Association]
        public Hoadon Phieu
        {
            get { return _Phieu; }
            set { SetPropertyValue<Hoadon>(nameof(Phieu), ref _Phieu, value); }

        }


        private Sanpham _Hang;
        [XafDisplayName("Hàng")]
        [Association]
        public Sanpham Hang
        {
            get { return _Hang; }
            set
            {
                if (SetPropertyValue<Sanpham>(nameof(Hang), ref _Hang, value) && !IsLoading && value != null)
                {
                    Dongia = value.Giaban;
                    Thanhtien = (decimal)Soluong * Dongia;
                }
            }
        }

        private double _Soluong;
        [XafDisplayName("Số lượng")]
        public double Soluong
        {
            get { return _Soluong; }
            set
            {
                if (SetPropertyValue<double>(nameof(Soluong), ref _Soluong, value) && !IsLoading)
                    Thanhtien = (decimal)Soluong * Dongia;
            }
        }

        private decimal _Dongia;
        [XafDisplayName("Đơn giá")]
        [ModelDefault("DisplayFormat", "{0:### ### ###}")]

        public decimal Dongia
        {
            get { return _Dongia; }
            set { SetPropertyValue<decimal>(nameof(Dongia), ref _Dongia, value); }
        }


        private decimal _Thanhtien;
        [XafDisplayName("Thành tiền")]
        [ModelDefault("DisplayFormat", "{0:### ### ###}")]


        public decimal Thanhtien
        {
            get { return _Thanhtien; }
            set { SetPropertyValue<decimal>(nameof(Thanhtien), ref _Thanhtien, value); }
        }

    }
}