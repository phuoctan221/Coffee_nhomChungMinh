using Coffee_nhomChungMinh.Module.BusinessObjects;
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
    [DefaultProperty("Soban")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
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

        private int _Soban;
        [XafDisplayName("Số bàn")]
        public int Soban
        {
            get { return _Soban; }
            set { SetPropertyValue<int>(nameof(Soban), ref _Soban, value); }
        }


        private DateTime _Ngay;
        [XafDisplayName("Ngày")]
        public DateTime Ngay
        {
            get { return _Ngay; }
            set { SetPropertyValue<DateTime>(nameof(Ngay), ref _Ngay, value); }
        }

        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<HoadonCT> HoadonCTs
        {
            get { return GetCollection<HoadonCT>(nameof(HoadonCTs)); }
        }

        [XafDisplayName("Tổng tiền")]
        [ModelDefault("DisplayFormat", "{0:### ### ###}")]

        public decimal Tongtien
        {
            get
            {
                decimal tien = 0;
                foreach (HoadonCT item in HoadonCTs)
                    tien += item.Thanhtien;
                return tien;
            }
        }

    }
}