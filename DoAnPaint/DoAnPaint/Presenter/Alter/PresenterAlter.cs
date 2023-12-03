using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;



namespace DoAnPaint.Presenter.Alter
{

    /// Interface cập nhật ứng dụng từ yêu cầu người dùng

    interface PresenterAlter
    {

        /// Phương thức group một hình 
  
        void onClickDrawGroup();


        /// Phương thức ungroup một hình 

        void onClickDrawUnGroup();

   
        /// Phương thức xóa một hình 
       
        void onClickDeleteShape();

    
        /// Phương thức xóa tất cả các hình
        /// </summary>
        /// <param name="picturebox"><Picturebox cần xóa/param>
        void onClickClearAll(PictureBox picturebox);


        /// Phương thức lưu một hình
    
        /// <param name="picturebox"><Picturebox cần lưu/param>
        void onClickSaveImage(PictureBox picturebox);

       
        /// Phương thức mở một hình lên picturebox
        /// <param name="picturebox"><Picturebox cần xóa/param>
        void onClickOpenImage(PictureBox picturebox);

        /// Phương thức tạo một hình vẽ mới từ picturebox
        /// <param name="picturebox"><Picturebox cần xóa/param>
        void onClickNewImage(PictureBox picturebox);
        /// Phương thức gọi tắt ứng dụng từ picturebox
        /// <param name="picturebox"><Picturebox cần xóa/param>
        void onClickShutdown(PictureBox picturebox);
        /// Phương thức xử lý nhấn tổ hợp phím trên picturebox
        /// <param name="picturebox"><Picturebox cần xóa/param>
        void onUseKeyStrokes(PictureBox picturebox, Keys key);

    }
}
