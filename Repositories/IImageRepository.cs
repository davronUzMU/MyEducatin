using MyEducatin.Models;

namespace MyEducatin.Repositories
{
    public interface IImageRepository
    {
        List<Img> GetImageAll();
        Img GetImageById(int id);
        Img AddImage(Img image);
        void DeleteImage(int id);
    }
}
