﻿using Coffee_nhomChungMinh.Module.BusinessObjects;
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
    [System.ComponentModel.DisplayName("Thực đơn")]
    [DefaultProperty("TenSP")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
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
        [XafDisplayName("Tên món")]
        public string TenSP
        {
            get { return _TenSP; }
            set { SetPropertyValue<string>(nameof(TenSP), ref _TenSP, value); }
        }

        private string _Dvt;
        [XafDisplayName("ĐVT"), Size(10)]
        public string Dvt
        {
            get { return _Dvt;}
            set { SetPropertyValue<string>(nameof(Dvt), ref _Dvt, value); }
        }

        private decimal _Giaban;
        [XafDisplayName("Giá bán")]
        [ModelDefault("DisplayFormat", "{0:### ### ###}")]
        public decimal Giaban
        {
            get { return _Giaban; }
            set { SetPropertyValue<decimal>(nameof(Giaban), ref _Giaban, value); }
        }


        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<HoadonCT> HoadonCTs
        {
            get { return GetCollection<HoadonCT>(nameof(HoadonCTs)); }
        }
        //



        private NhomSP _Nhom;
        [Association, XafDisplayName("Nhóm")]
        public NhomSP Nhom
        {
            get { return _Nhom; }
            set { SetPropertyValue<NhomSP>(nameof(Nhom), ref _Nhom, value); }
        }

    }
}