using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFRESTReportingservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRESTReportingservice" in both code and config file together.
    //[ServiceContract]
    //public interface IRESTReportingservice
    //{
    //    [OperationContract]
    //    void DoWork();
    //}

    //WCF RESTfull service(added assembly reference - System.ServiceModel.Web for using Restfull service attributes) CRUD using Entity framework
    [ServiceContract]
    public interface IWCFRESTEmployeeservice
    {
        //Got the below error when  its int Id , so converted it to string
        //Operation 'GetWCFRESTEmployee' in contract 'IWCFRESTEmployeeservice' has a path variable named 'Id' which does not have type 'string'.  Variables for UriTemplate path segments must have type 'string'

        //More idea https://social.msdn.microsoft.com/Forums/vstudio/en-US/969ce363-4c0f-4642-b751-35e517336b0d/wcf-rest-variables-for-uritemplate-path-segments-must-have-type-string?forum=wcf
        //can invoke the service with int input parameter this way - http://localhost/WCFRESTReportingserviceEndpointsHostedIIS/WCFRESTReportingservice.svc/empbyid/?Id=7


    //        Currently, the type of variables for UriTemplate path segments is limited to type 'string'. For above sample, you can move id to query part:
    //[OperationContract]
    //        [WebGet(UriTemplate = "Entity/?id={id}")]
    //        Entity Find(Int32 id);

    //        [OperationContract]
    //        [WebGet(UriTemplate = "/Entity/?data={data}", RequestFormat = WebMessageFormat.Json)]
    //        String GetData(String data);

    //        This accepted a JSON String of: {"FirstName":"John","MiddleName":"H","LastName":"Doe"}
    //    the complete REST request was as follows:

    //http://localhost:8081/SampleRESTWebService/Service.svc/Entity/?data={"FirstName":"John","MiddleName":"H","LastName":"Doe"}

        [OperationContract]
        [WebInvoke(Method = "GET",
            //RequestFormat =WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml,
            UriTemplate = "empbyid/?Id={Id}")]
            //BodyStyle = WebMessageBodyStyle.Wrapped)]
        WCFEmployee GetWCFRESTEmployee(int Id);

        //Server Error in '/' Application.
        //Operation 'SaveWCFERESTmployee' in contract 'IWCFRESTEmployeeservice' has a UriTemplate that expects a parameter named 'ID', but there is no input parameter with that name on the operation.

        //Operation 'SaveWCFERESTmployee' in contract 'IWCFRESTEmployeeservice' has a path variable named 'Employee' which does not have type 'string'.  Variables for UriTemplate path segments must have type 'string'.

        //[OperationContract]
        //[WebInvoke(Method = "PUT",
        //    RequestFormat = WebMessageFormat.Xml,
        //    ResponseFormat = WebMessageFormat.Xml,
        //    UriTemplate = "SaveWCFERESTmployee/{Employee}",
        //    BodyStyle = WebMessageBodyStyle.Bare)]
        //void SaveWCFERESTmployee(WCFEmployee Employee);

        //[OperationContract]
        //[WebInvoke(Method = "PUT",
        //    RequestFormat = WebMessageFormat.Xml,
        //    ResponseFormat = WebMessageFormat.Xml,
        //    UriTemplate = "UpdateWCFRESTEmployee/{Id}",
        //    BodyStyle = WebMessageBodyStyle.Bare)]
        //string UpdateWCFRESTEmployee(WCFEmployee Employee);

        [OperationContract]
        [WebInvoke(Method = "GET",
            //RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml,
            UriTemplate = "allemp")]
            //BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<WCFEmployee> ALLWCFRESTEmployee();

    }

}
