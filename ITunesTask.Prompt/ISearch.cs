using System.Threading.Tasks;
using ITunesTask.Search;

namespace ITunesTask.Prompt
{
    public interface ISearch
    {
        void OnValidate(Arguments args);
        void DisplayError(Arguments args);
        object Fetch(Arguments args);
    }
}