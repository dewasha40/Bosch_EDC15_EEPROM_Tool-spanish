using System.Diagnostics;
using System.Windows;
using Microsoft.Win32;

namespace Edc15EepromTool.Services;

/// <summary>File dialogs, links and the clipboard, kept out of the view model so it stays testable.</summary>
public interface IShellService
{
    string? PickFileToOpen();

    string? PickFileToSave(string suggestedName, string? folder);

    void OpenUrl(string url);

    bool CopyText(string text);
}

public sealed class ShellService : IShellService
{
    private const string Filter = "Archivo EEPROM (*.bin)|*.bin|Todos los archivos (*.*)|*.*";

    public string? PickFileToOpen()
    {
        var dialog = new OpenFileDialog
        {
            Title = "Abrir un archivo EEPROM EDC15",
            Filter = Filter,
        };
        return dialog.ShowDialog() == true ? dialog.FileName : null;
    }

    public string? PickFileToSave(string suggestedName, string? folder)
    {
        var dialog = new SaveFileDialog
        {
            Title = "Guardar el archivo EEPROM modificado",
            Filter = Filter,
            FileName = suggestedName,
            InitialDirectory = folder ?? string.Empty,
            OverwritePrompt = true,
        };
        return dialog.ShowDialog() == true ? dialog.FileName : null;
    }

    public void OpenUrl(string url) => Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

    public bool CopyText(string text)
    {
        try
        {
            Clipboard.SetText(text);
            return true;
        }
        catch (System.Runtime.InteropServices.COMException)
        {
            // another application holds the clipboard
            return false;
        }
    }
}

