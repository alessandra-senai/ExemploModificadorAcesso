namespace ProjetoExemploA
{
    public class WorkItem
    {
        private static int currentID;
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
 
        public WorkItem()
        {
            ID = 0;
            Title = "Default title";
            Description = "Default description.";
        }

        
        public WorkItem(string title, string desc)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.Description = desc;
        }

        static WorkItem() => currentID = 0;
        protected int GetNextID() => ++currentID;

         
        public void Update(string title)
        {
            this.Title = title;
        }

        public  string ReturnWorkItemInformation(WorkItem workItem) {
            return $"ID: {workItem.ID} - Title: {workItem.Title} - Description:{workItem.Description}";
        }
         

    }
}
