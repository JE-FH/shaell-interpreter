namespace PipeHelper;

public interface IPipelineElement
{
    void CaptureOutput(string outName);
    string GetOutput(string outputName);
    int Run(IEnumerable<string> arguments, string? input);
}