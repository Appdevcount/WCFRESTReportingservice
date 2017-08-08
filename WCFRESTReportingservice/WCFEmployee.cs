namespace WCFRESTReportingservice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    using System.Xml;
    using System.Xml.Serialization;

    [DataContract]//(Namespace ="")]
    [XmlRoot(ElementName = "WCFEmployee",Namespace = "http://schemas.datacontract.org/2004/07/WCFRESTReportingservice")]
    [Table("WCFEmployee")]
    public partial class WCFEmployee
    {
        
        [DataMember(Order =1)]
        [XmlElement]
        public int Id { get; set; }

        [DataMember(Order = 2)]
        [XmlElement]
        [StringLength(50)]
        public string Name { get; set; }

        [DataMember(Order = 3)]
        [XmlElement]
        [StringLength(50)]
        public string Gender { get; set; }

        //http://stackoverflow.com/questions/7672534/serializing-object-to-xml-and-removing-unwanted-text-from-xml
        [DataMember(Order =4)]//, EmitDefaultValue = false)]
        [XmlElement]
        public DateTime? DateOfBirth { get; set; }

        [DataMember(Order =5)]//, EmitDefaultValue = false)]
        [XmlElement]
        public int? EmployeeType { get; set; }

        [DataMember(Order =6)]//, EmitDefaultValue = false)]
        [XmlElement]
        public int? AnnualSalary { get; set; }

        [DataMember(Order =7)]//, EmitDefaultValue = false)]
        [XmlElement]
        public int? HourlyPay { get; set; }

        [DataMember(Order =8)]//, EmitDefaultValue = false)]
        [XmlElement]
        public int? HoursWorked { get; set; }
    }
}
