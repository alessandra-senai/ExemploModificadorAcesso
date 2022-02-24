using ProjetoExemploA;

namespace ProjetoExemploB
{
    public class ChangeRequest : WorkItem
    {
        protected int OriginalItemID { get; set; }
 
        public ChangeRequest() { }

        public ChangeRequest(string title, string desc, int originalID)
        {
            
            this.ID = GetNextID();
            this.Title = title;
            this.Description = desc;
           
           
            this.OriginalItemID = originalID;
        }

        public  string ReturnChangeRequestInformation(ChangeRequest changeRequest)
        {
            return $"ID: {changeRequest.ID} - Title: {changeRequest.Title} - Description:{changeRequest.Description}";
        }

    }
}
