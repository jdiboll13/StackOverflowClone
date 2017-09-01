using System;
namespace StackOverflowClone.Models
{
    public class AnswersModel
    {
        public int ID
        {
            get;
            set;
        }
        public string Body
        {
            get;
            set;
        }

		public int VoteCount
		{
			get;
			set;
		}
		public DateTime DatePosted
		{
			get;
			set;
		}
        public int UserID
        {
            get;
            set;
        }
        public UsersModel UsersModel
        {
            get;
            set;
        }
        public int QuestionID
        {
            get;
            set;
        }
        public QuestionsModel QuestionsModel
        {
            get;
            set;
        }
    }
}
