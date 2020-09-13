namespace NTourism.Models.Regular
{
    public class TblAttractionPollRel
    {
        public int id { get; set; }
        public int AttractionId { get; set; }
        public int PollId { get; set; }

        public TblAttractionPollRel(int id)
        {
            this.id = id;
        }

		public TblAttractionPollRel(int id, int AttractionId, int pollId)
        {
            this.id = id;
            AttractionId = AttractionId;
            PollId = pollId;
        }

        public TblAttractionPollRel(int AttractionId, int pollId)
        {
            AttractionId = AttractionId;
            PollId = pollId;
        }

        public TblAttractionPollRel()
        {
            
        }
    }
}