using DeveloperEvaluation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DeveloperEvaluation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NumbersModel model = new NumbersModel();
            model.mean = 0;
            model.median = 0;
            model.modes = "0";
            return View(model);
        }
        
        [HttpPost]
        public ActionResult Index(string input)
        {
            NumbersModel model = new NumbersModel();

            List<int> numbersList = ConvertStringToInts(input);

            model.input = input;
            model.mean = FindMean(numbersList);
            model.modes = ConvertIntsToString(FindMode(numbersList));
            model.median = FindMedian(numbersList);
            return View(model);
        }

        public double FindMean(List<int> numbersList)
        {
            double sum = 0;
            double mean;
            for(int i = 0; i < numbersList.Count; i++)
            {
                sum += (double)numbersList[i];
            }
            if(numbersList.Count > 0)
            {
                mean = sum / numbersList.Count;
            }
            else
            {
                mean = 0;
            }

            return mean;
        }

        public List<int> FindMode(List<int> numbersList)
        {
            List<int> modes = new List<int>();
            Dictionary<int, int> numberCounts = new Dictionary<int, int>();
            foreach(int i in numbersList)
            {
                if (numberCounts.ContainsKey(i))
                {
                    numberCounts[i] = numberCounts[i] + 1;
                }
                else
                {
                    numberCounts[i] = 1;
                }
            }

            int max = 0;
            foreach(int key in numberCounts.Keys)
            {
                if(numberCounts[key] > max)
                {
                    max = numberCounts[key];
                }
            }

            foreach (int key in numberCounts.Keys)
            {
                if (numberCounts[key] == max)
                {
                    modes.Add(key);
                }
            }

            return modes;
        }

        public double FindMedian(List<int> numbersList)
        {
            double median;
            int[] numbersArray = numbersList.ToArray();
            Array.Sort(numbersArray);
            if (numbersArray.Length > 0)
            {
                if (numbersArray.Length % 2 == 0)
                {
                    int firstIndex = numbersArray.Length / 2 - 1;
                    int secondIndex = numbersArray.Length / 2;
                    median = ((double)numbersArray[firstIndex] + (double)numbersArray[secondIndex]) / 2;
                }
                else
                {
                    int index = (numbersArray.Length - 1) / 2;
                    median = numbersArray[index];
                }
            }
            else
            {
                median = 0;
            }
            return median;
        }
        public List<int> ConvertStringToInts(string input)
        {
            List<int> numbers = new List<int>();
            foreach (var s in input.Split(','))
            {
                int currentNum;
                if(int.TryParse(s, out currentNum))
                {
                    numbers.Add(currentNum);
                }
            }
            return numbers;
        }

        public string ConvertIntsToString(List<int> input)
        {
            string numbers = "";
            for(int i = 0; i < input.Count; i++)
            {
                numbers += input[i].ToString();
                if(i < input.Count - 1)
                {
                    numbers += ",";
                }
            }
            return numbers;
        }
    }
}
