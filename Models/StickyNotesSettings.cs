namespace StickyNotesProfilePicker.Models;

public sealed class StickyNotesSettings
{
    public string DataDirectory { get; set; } = @"C:\profiles_store\StickyNotesProfiles";
    public string StickyNotesExePath { get; set; } = @"C:\Program Files\StickyNotesApp\StickyNotesApp.exe";
}
