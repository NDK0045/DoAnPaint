using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;



namespace DoAnPaint.Presenter.Updates
{

    /// Interface xử lý yêu cầu cập nhật dữ liệu từ người dùng

    interface PresenterUpdate
    {

 
        /// Phương thức xử lý khi người dụng chọn chế độ select
   
        void onClickSelectMode();
        /// Phương thức xử lý khi người dụng chọn thay đổi màu sắc
        /// <param name="color">Màu cần đổi</param>
        /// <param name="g">Áp dụng lên graphic g</param>
        void onClickSelectColor(Color color,Graphics g);

        /// Phương thức xử lý khi người dụng chọn thay đôi kích thước đường vẽ
        /// <param name="size"></param>
        void onClickSelectSize(int size);

        /// Phương thức xử lý khi người dụng chọn chế độ fill
        /// <param name="btn"></param>
        /// <param name="g"></param>
        void onClickSelectFill(Button btn, Graphics g);


    }
}
