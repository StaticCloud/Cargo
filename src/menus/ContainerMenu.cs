﻿using Cargo.src.interfaces;
using Cargo.src.services;
using Spectre.Console;

namespace Cargo.src.menus
{
    internal class ContainerMenu : IMenu
    {
        private string _title;
        private string _id;
        private string[] _choices;
        
        public ContainerMenu(string image, Services services) 
        {
            _choices = ["Start new container", "Manage existing container"];
            _title = image.Split(' ')[1];
            _id = image.Split(' ')[0];

            Render();
        }

        public void Render()
        {
            string choice = AnsiConsole.Prompt(new SelectionPrompt<string>().Title($"What operation would you like to perform on {_title}:").AddChoices(_choices));
        }
    }
}
