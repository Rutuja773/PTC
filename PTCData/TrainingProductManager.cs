using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCData
{
    public class TrainingProductManager
    {
        public List<TrainingProduct> Get(TrainingProduct entity)
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();

            //TODO: Add your data access method here
            ret = CreateMockData();

            if(!string.IsNullOrEmpty(entity.TopicName))
            {
                ret = ret.FindAll(p => p.TopicName.ToLower().StartsWith(entity.TopicName, StringComparison.CurrentCultureIgnoreCase));
            }

            return ret;
        }
        private List<TrainingProduct> CreateMockData()
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();

            ret.Add(new TrainingProduct() 
            {
                ProductId = 1,
                TopicName = "C# Basic Fundamentals",
                IntroductionDate = Convert.ToDateTime("11/13/2022"),
                Url = "https://W3school.com",
                Price = Convert.ToDecimal(29.00)
            });
           

            ret.Add(new TrainingProduct()
            {
                ProductId = 2,
                TopicName = "HTML and CSS",
                IntroductionDate = Convert.ToDateTime("11/14/2022"),
                Url = "https://youtube.com",
                Price = Convert.ToDecimal(29.00)
            });
            

            ret.Add(new TrainingProduct()
            {
                ProductId = 3,
                TopicName = "Javascript and Typescript",
                IntroductionDate = Convert.ToDateTime("11/15/2022"),
                Url = "https://pluralsight.com",
                Price = Convert.ToDecimal(29.00)
            });
           

            ret.Add(new TrainingProduct()
            {
                ProductId = 4,
                TopicName = "SQL",
                IntroductionDate = Convert.ToDateTime("11/16/2022"),
                Url = "https://youtube.com",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 5,
                TopicName = "ASP.NET MVC",
                IntroductionDate = Convert.ToDateTime("11/16/2022"),
                Url = "https://pluralsight.com",
                Price = Convert.ToDecimal(29.00)
            });
            return ret;



        }
    }
}
