using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignChat_Maintenance
{
    class SignChatDB
    {
        public bool LoginValidation(String username, String password)
        {
            using (database content = new database())
            {
                administrator admin = content.administrator.Where(i => i.username == username && i.password == password).FirstOrDefault();

                if (admin == null)
                {
                    return false;
                } else
                {
                    return true;
                }
            }
        }

        public List<organisation> GetOrganisationList()
        {
            using (database content = new database())
            {
                List<organisation> list = content.organisation.Select(i => i).ToList();
                return list;
            }
        }

        public List<signcollection> GetCollectionList()
        {
            using (database content = new database())
            {
                List<signcollection> list = content.signcollection.Select(i => i).ToList();
                foreach(signcollection c in list)
                {
                    c.organisation = content.organisation.First(i => i.id == c.organisationId);
                    c.sign = content.sign.Where(i => i.collectionId == c.collectionId).Select(i => i).ToList();
                }
                return list;
            }
        }

        public List<signcollection> GetCollectionList(int organisationId)
        {
            using (database content = new database())
            {
                List<signcollection> list = content.signcollection.Where(i => i.organisationId == organisationId).Select(i => i).ToList();
                foreach (signcollection c in list)
                {
                    c.organisation = content.organisation.First(i => i.id == c.organisationId);
                    c.sign = content.sign.Where(i => i.collectionId == c.collectionId).Select(i => i).ToList();
                }
                return list;
            }
        }

        public int GetNoOfSign(String collectionId)
        {
            using (database content = new database())
            {
                int count = content.sign.Where(i => i.collectionId == collectionId).GroupBy(u => u.meaning).Count();
                return count;
            }
        }

        public int GetNoOfDataset(String collectionId)
        {
            using (database content = new database())
            {
                List<sign> list = content.sign.Where(i => i.collectionId == collectionId).ToList();
                return list.Count();
            }
        }

        public signcollection GetSignCollection(String collectionId)
        {
            using (database content = new database())
            {
                signcollection collection = content.signcollection.Where(i => i.collectionId == collectionId).FirstOrDefault();
                return collection;
            }
        }

        public List<sign> GetSigns(String collectionId)
        {
            using (database content = new database())
            {
                List<sign> signs = content.sign.Where(i => i.collectionId == collectionId).OrderBy(i => i.meaning).ToList();
                return signs;
            }
        }

        public organisation GetOrganisation(int organisationId)
        {
            using (database content = new database())
            {
                organisation org = content.organisation.Where(i => i.id == organisationId).FirstOrDefault();
                return org;
            }
        }

        public void UpdateSignCollection(signcollection sc)
        {
            using (database content = new database())
            {
                signcollection ori = content.signcollection.FirstOrDefault(i => i.collectionId == sc.collectionId);
                if (ori != null)
                {
                    ori.password = sc.password;
                    ori.name = sc.name;
                    ori.contactPerson = sc.contactPerson;
                    ori.contactPersonEmail = sc.contactPersonEmail;
                    ori.contactPersonTel = sc.contactPersonTel;
                    ori.contactPersonTitle = sc.contactPersonTitle;
                    content.SaveChanges();
                }
            }
        }

        public void UpdateOrganisation(organisation org)
        {
            using (database content = new database())
            {
                organisation ori = content.organisation.FirstOrDefault(i => i.id == org.id);
                if (ori != null)
                {
                    ori.name = org.name;
                    ori.email = org.email;
                    ori.address = org.address;
                    ori.tel = org.tel;
                    content.SaveChanges();
                }
            }
        }

        public void UpdateAdministrator(administrator admin)
        {
            using (database content = new database()) 
            {
                administrator a = content.administrator.FirstOrDefault(i => i.username == admin.username);
                a.password = admin.password;
                content.SaveChanges();
            }
        }

        public int NewOrganisation(organisation org)
        {
            using (database content = new database())
            {
                content.organisation.Add(org);
                content.SaveChanges();

                organisation newOrg = content.organisation.OrderByDescending(i => i.id).FirstOrDefault();
                return newOrg.id;
            }
        }

        public void NewCollection(signcollection clt)
        {
            using (database content = new database())
            {
                content.signcollection.Add(clt);
                content.SaveChanges();
            }
        }
    }
}
