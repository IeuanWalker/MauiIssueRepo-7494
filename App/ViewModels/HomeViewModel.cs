using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace App.ViewModels;

public partial class HomeViewModel : BaseViewModel
{
	public HomeViewModel()
	{
		DateTime end = DateTime.Now.AddDays(1);
		DateTime start = DateTime.Now.AddDays(-30);
		Logs = new ObservableCollection<TestModel>(Enumerable.Range(0, 1 + end.Subtract(start).Days)
			.Select(offset => start.AddDays(offset))
			.Select(x => new TestModel
			{
				Date = x
			}));

		SelectedLog = Logs.Last();

		Logs[2].Exercieses = null;
	}

	[ObservableProperty]
	ObservableCollection<TestModel> _logs = new();

	[ObservableProperty]
	TestModel _selectedLog = null!;
}

public class TestModel
{
	public DateTime Date { get; set; }

	public string DateDisplayTest
	{
		get
		{
			if (Date.Date.Equals(DateTime.Now.Date))
			{
				return "Today";
			}
			else if (Date.Date.Equals(DateTime.Now.AddDays(-1).Date))
			{
				return "Yesterday";
			}

			return Date.ToString("d, MMMM yyyy");
		}
	}

	public List<LoggedExerciesModel>? Exercieses { get; set; } = new()
	{
		new()
		{
			Name = "Bicep curls",
			Sets = new()
			{
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 35,
					Reps = 3
				}
			}
		},
		new()
		{
			Name = "Seated cable row",
			Sets = new()
			{
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 70,
					Reps = 10,
					NewRecord = true
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				}
			}
		},
		new()
		{
			Name = "Tricep extension",
			Sets = new()
			{
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
			}
		},
		new()
		{
			Name = "Bicep curls",
			Sets = new()
			{
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 35,
					Reps = 3
				}
			}
		},
		new()
		{
			Name = "Seated cable row",
			Sets = new()
			{
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 70,
					Reps = 10,
					NewRecord = true
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				}
			}
		},
		new()
		{
			Name = "Tricep extension",
			Sets = new()
			{
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
			}
		},
		new()
		{
			Name = "Bicep curls",
			Sets = new()
			{
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 35,
					Reps = 3
				}
			}
		},
		new()
		{
			Name = "Seated cable row",
			Sets = new()
			{
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 70,
					Reps = 10,
					NewRecord = true
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				}
			}
		},
		new()
		{
			Name = "Tricep extension",
			Sets = new()
			{
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
			}
		},
		new()
		{
			Name = "Bicep curls",
			Sets = new()
			{
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 35,
					Reps = 3
				}
			}
		},
		new()
		{
			Name = "Seated cable row",
			Sets = new()
			{
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 70,
					Reps = 10,
					NewRecord = true
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				}
			}
		},
		new()
		{
			Name = "Tricep extension",
			Sets = new()
			{
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
			}
		},
		new()
		{
			Name = "Bicep curls",
			Sets = new()
			{
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 35,
					Reps = 3
				}
			}
		},
		new()
		{
			Name = "Seated cable row",
			Sets = new()
			{
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 70,
					Reps = 10,
					NewRecord = true
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				}
			}
		},
		new()
		{
			Name = "Tricep extension",
			Sets = new()
			{
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
			}
		},
		new()
		{
			Name = "Bicep curls",
			Sets = new()
			{
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 35,
					Reps = 3
				}
			}
		},
		new()
		{
			Name = "Seated cable row",
			Sets = new()
			{
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 70,
					Reps = 10,
					NewRecord = true
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				}
			}
		},
		new()
		{
			Name = "Tricep extension",
			Sets = new()
			{
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
			}
		},
		new()
		{
			Name = "Bicep curls",
			Sets = new()
			{
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 35,
					Reps = 3
				}
			}
		},
		new()
		{
			Name = "Seated cable row",
			Sets = new()
			{
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 70,
					Reps = 10,
					NewRecord = true
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				}
			}
		},
		new()
		{
			Name = "Tricep extension",
			Sets = new()
			{
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
			}
		},
		new()
		{
			Name = "Bicep curls",
			Sets = new()
			{
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 35,
					Reps = 3
				}
			}
		},
		new()
		{
			Name = "Seated cable row",
			Sets = new()
			{
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 70,
					Reps = 10,
					NewRecord = true
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				}
			}
		},
		new()
		{
			Name = "Tricep extension",
			Sets = new()
			{
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
			}
		},
		new()
		{
			Name = "Bicep curls",
			Sets = new()
			{
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 35,
					Reps = 3
				}
			}
		},
		new()
		{
			Name = "Seated cable row",
			Sets = new()
			{
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 70,
					Reps = 10,
					NewRecord = true
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				}
			}
		},
		new()
		{
			Name = "Tricep extension",
			Sets = new()
			{
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
			}
		},
		new()
		{
			Name = "Bicep curls",
			Sets = new()
			{
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 42.5,
					Reps = 10
				},
				new()
				{
					Weight = 35,
					Reps = 3
				}
			}
		},
		new()
		{
			Name = "Seated cable row",
			Sets = new()
			{
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 70,
					Reps = 10,
					NewRecord = true
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				},
				new()
				{
					Weight = 60,
					Reps = 10
				}
			}
		},
		new()
		{
			Name = "Tricep extension",
			Sets = new()
			{
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
				new()
				{
					Weight = 26.25,
					Reps = 10
				},
			}
		}
	};
}

public class LoggedExerciesModel
{
	public string Name { get; set; } = string.Empty;
	public List<SetsModels> Sets { get; set; } = new();
}
public class SetsModels
{
	public double Weight { get; set; }
	public int Reps { get; set; }
	public bool NewRecord { get; set; }
}