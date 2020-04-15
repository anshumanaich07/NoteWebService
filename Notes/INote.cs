using Notes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Notes
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface INote
    {
        [OperationContract]
        int AddNote(String Username, String Heading, String Body);

        [OperationContract]
        int DeleteNote(int id, String Username);

        [OperationContract]
        int UpdateNoteBody(int id, String UserName, String Body);

        [OperationContract]
        int UpdateNoteHeading(int id, String UserName, String Heading);

        [OperationContract]
        Note GetNote(String Username, int id);

        [OperationContract]
        List<Note> GetAllNote(String Username);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Notes.ContractType".
    
}
