using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SharesBusiness
{
    public partial class Member
    {
        #region Declaration

        private string _dataPath = string.Empty;

        #endregion
        
        #region Constructors

        public Member()
        {
        }

        public Member(string dataPath)
        {
            this._dataPath = dataPath;
        }

        public Member(string dataFolder, string dataFileName)
        {
            this._dataPath = string.Concat(dataFolder, @"\", dataFileName);
        }

        public Member(MemberTitle title, string firstName, string lastName, MemberType type, string dataPath)
        {
            this.Title = title;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Type = type;
            this._dataPath = dataPath;
        }

        #endregion

        #region Public Methods

        public int Add()
        {
            TextWriter memberFile = null;

            try
            {
                StringBuilder memberValues = new StringBuilder();

                memberValues.Append(Convert.ToInt32(this.Title) + "~");
                memberValues.Append(this.FirstName.ToString() + "~");
                memberValues.Append(this.LastName.ToString() + "~");
                memberValues.Append(Convert.ToInt32(this.Type));
                memberFile = new StreamWriter(_dataPath, true);
                memberFile.WriteLine(memberValues.ToString());

                return 0;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (memberFile != null)
                {
                    memberFile.Close();
                }
            }
        }

        public List<Member> ViewAll()
        {
            StreamReader memberFile = null;

            try
            {
                memberFile = new StreamReader(_dataPath);
                string memberRecord = string.Empty;
                List<Member> members = new List<Member>();

                memberRecord = memberFile.ReadLine();

                while (!string.IsNullOrEmpty(memberRecord) && !string.IsNullOrWhiteSpace(memberRecord))
                {
                    Member member = new Member();
                    string[] memberValues = memberRecord.Split('~');

                    member.Title = (MemberTitle)Convert.ToInt32(memberValues[0]);
                    member.FirstName = memberValues[1];
                    member.LastName = memberValues[2];
                    member.Type = (MemberType)Convert.ToInt32(memberValues[3]);

                    members.Add(member);

                    memberRecord = memberFile.ReadLine();
                }

                return members;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (memberFile != null)
                {
                    memberFile.Close();
                }
            }
        }

        #endregion


    }
}
