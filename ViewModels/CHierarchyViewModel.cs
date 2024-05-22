using CG.UI.Models;
using CG.UI.Pages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CG.UI.BL;
using System.Globalization;

namespace CG.UI.ViewModels;

public partial class CHierarchyViewModel : AbstractViewModelWithBreadcrumb
{
    [ObservableProperty]
    private List<CHierarchy> _nodes;

    public CHierarchyViewModel()
    {
        
    }

    public async Task Init()
    {
        Nodes = new List<CHierarchy>() 
        {
            new CHierarchy() { Name = "ROOT", Id = 1, ParentId = null, Details =   "Details"},
            new CHierarchy() { Name = "Child 1", Id = 2, ParentId = 1, Details =   "Details" },
            new CHierarchy() { Name = "Child 2", Id = 3, ParentId = 1, Details =   "Details"},
            new CHierarchy() { Name = "Child 3", Id = 4, ParentId = 1, Details =   "Details"},
            new CHierarchy() { Name = "Child 4", Id = 5, ParentId = 1, Details =   "Details"},
            new CHierarchy() { Name = "Child 5", Id = 6, ParentId = 1, Details =   "Details"},
            new CHierarchy() { Name = "Child 6", Id = 7, ParentId = 1, Details =   "Details"},
            new CHierarchy() { Name = "Child 7", Id = 8, ParentId = 1, Details =   "Details"},
            new CHierarchy() { Name = "Child 8", Id = 9, ParentId = 1, Details =   "Details"},
            new CHierarchy() { Name = "Child 9", Id = 10, ParentId = 1, Details =  "Details"},
            new CHierarchy() { Name = "Child 10", Id = 11, ParentId = 1, Details = "Details"},
            new CHierarchy() { Name = "Child 11", Id = 12, ParentId = 1, Details = "Details"},
            //new CHierarchy() { Name = "Child 12", Id = 13, ParentId = 1, Details = "Details"},
            //new CHierarchy() { Name = "Child 13", Id = 14, ParentId = 1, Details = "Details" },
            //new CHierarchy() { Name = "Child 14", Id = 15, ParentId = 1, Details = "Details" },
            //new CHierarchy() { Name = "Child 15", Id = 16, ParentId = 1, Details = "Details" },
            //new CHierarchy() { Name = "Child 16", Id = 17, ParentId = 1, Details = "Details" },
            new CHierarchy() { Name = "Ch 1", Id = 18, ParentId = 10, Details = "Details" },
            new CHierarchy() { Name = "Ch 2", Id = 19, ParentId = 10, Details = "Details" },
            new CHierarchy() { Name = "Ch 3", Id = 20, ParentId = 10, Details = "Details" },
            new CHierarchy() { Name = "Ch 4", Id = 21, ParentId = 10, Details = "Details" },
            new CHierarchy() { Name = "Ch 5", Id = 22, ParentId = 10, Details = "Details" },
            new CHierarchy() { Name = "Ch 6", Id = 23, ParentId = 10, Details = "Details" },
        };
    }
}