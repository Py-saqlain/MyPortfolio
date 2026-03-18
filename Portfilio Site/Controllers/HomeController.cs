using Microsoft.AspNetCore.Mvc;
using Portfilio_Site.Models; // <-- Changed this!
using System.Collections.Generic;

namespace Portfilio_Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // 1. Create a hardcoded list of your specific projects
            var myProjects = new List<ProjectModel>
            {
                new ProjectModel
                {
                    Id = 1,
                    Title = "Customer Support Bot",
                    Description = "Built a production-ready customer support chatbot with multi-turn memory and intent-aware responses using LangChain\r\nand GroqAPI & Integrated FAISS vector store for FAQ retrieval.\r\n• Deployed live on Streamlit with HuggingFace Spaces hosting",
                    TechStack = "Python, LangChain, GroqAPI, Streamlit, HuggingFace Spaces",
                    GithubLink = "https://github.com/Py-saqlain/Customer-support-bot"
                },
                new ProjectModel
                {
                    Id = 2,
                    Title = "Movie Recap App",
                    Description = "Built end-to-end RAG pipeline automating scene detection and recap generation from raw video using semantic content\r\nanalysis.\r\n• Integrated FAISS vector storage for scene embedding retrieval — deployed on HuggingFace Spaces.\r\n",
                    TechStack = "Python, Langchain, RAG, FAISS",
                    GithubLink = "https://github.com/Py-saqlain/Movie_Recap"

                },
                new ProjectModel
                {
                    Id = 3,
                    Title = "Timely E-commerce App",
                    Description = "A fast and responsive e-commerce platform built for modern online Watches shopping,implemented with MVC strcture, HTML5, Bootstrap and SignalR for live notifications",
                    TechStack = "C#, ASP.NET Core MVC",
                    GithubLink = "https://github.com/Py-saqlain/Movie_Recap"

                },
                new ProjectModel
                {
                    Id = 4,
                    Title = "Personal chat Bot",
                    Description = "Developed multi-turn conversational agent with persistent long-term memory using LangChain memory modules and vector\r\nstorage. Demonstrated 90%+ contextual accuracy across sessions in manual evaluation.\r\n",
                    TechStack = "Python, LangChain, GroqAPI",
                     GithubLink = "https://github.com/Py-saqlain/Personal-Chat-Assistant"
                },

                new ProjectModel
                {
                    Id = 5,
                    Title = "HAR Deep Learning Model",
                    Description = " Trained CNN classifier to recognize 6 human activity classes from image-based sensor data, achieving 87%+ validation\r\naccuracy.\r\n• Reduced overfitting by ~12% through dropout tuning and filter size optimization.\r\n",
                    TechStack = "Python, TensorFlow, Deep Learning"
                },
                
            };

            // 2. Hand this list directly to the View (HTML page)
            return View(myProjects);
        }
    }
}