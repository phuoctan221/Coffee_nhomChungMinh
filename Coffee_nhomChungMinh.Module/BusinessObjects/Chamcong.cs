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
    public class Chamcong : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Chamcong(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private Nhanvien _Nhanvien;
        [Association]
        public Nhanvien Nhanvien
        {
            get { return _Nhanvien; }
            set { SetPropertyValue<Nhanvien>(nameof(Nhanvien), ref _Nhanvien, value); }
        }


        private DateTime _Giovao;
        [XafDisplayName("Giờ vào")]
        public DateTime Giovao
        {
            get { return _Giovao; }
            set { SetPropertyValue<DateTime>(nameof(Giovao), ref _Giovao, value); }
        }


        private DateTime _Giora;
        [XafDisplayName("Giờ ra")]
        public DateTime Giora
        {
            get { return _Giora; }
            set { SetPropertyValue<DateTime>(nameof(Giora), ref _Giora, value); }
        }


    }
}