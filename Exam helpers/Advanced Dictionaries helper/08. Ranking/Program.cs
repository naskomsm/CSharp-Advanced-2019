using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestAndPassword = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> userDataForContests = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if(input=="end of contests")
                {
                    break;
                }

                string[] splittedInput = input.Split(new char[] { ':', }, StringSplitOptions.RemoveEmptyEntries);

                string contest = splittedInput[0];
                string passwordForContest = splittedInput[1];

                if (!contestAndPassword.ContainsKey(contest))
                {
                    contestAndPassword[contest] = passwordForContest;
                }
            }


            while (true)
            {
                string input = Console.ReadLine();
                if(input== "end of submissions")
                {
                    break;
                }
                
                string[] splittedInput = input.Split(new char[] { '=','>' }, StringSplitOptions.RemoveEmptyEntries);

                string contest = splittedInput[0];
                string password = splittedInput[1];
                string username = splittedInput[2];
                int points = int.Parse(splittedInput[3]);

                // validation
                if (contestAndPassword.ContainsKey(contest) && contestAndPassword[contest] == password)
                {
                    if (!userDataForContests.ContainsKey(username))
                    {
                        userDataForContests.Add(username, new Dictionary<string, int>());
                        userDataForContests[username].Add(contest, points);
                    }
                    else if (userDataForContests.ContainsKey(username))
                    {
                        if (userDataForContests[username].ContainsKey(contest))
                        {
                            if (points > userDataForContests[username][contest])
                            {
                                userDataForContests[username][contest] = points;
                            }
                        }
                        else
                        {
                            userDataForContests[username].Add(contest, points);
                        }
                    }
                }
            }

            string bestCandidate = string.Empty;
            int bestTotalPoints = 0;
            foreach (var kvp in userDataForContests)
            {
                string person = kvp.Key;
                int currenTotalPoints = 0;

                var collection = kvp.Value;
                foreach (var KVP in collection)
                {
                    currenTotalPoints += KVP.Value;
                }
                if(currenTotalPoints> bestTotalPoints)
                {
                    bestTotalPoints = currenTotalPoints;
                    bestCandidate = person;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestTotalPoints} points.");
            Console.WriteLine($"Ranking:");

            foreach (var kvp in userDataForContests.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var contest in userDataForContests[kvp.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }


        }
    }
}
