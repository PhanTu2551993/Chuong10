namespace Chuong10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Câu 1 :
                Việc sử dụng catch không có tham số (tức là không chỉ định loại ngoại lệ cụ thể nào) có thể tỏ ra tiện lợi vì nó bắt giữ mọi ngoại lệ có thể xảy ra trong khối try. 
                Tuy nhiên, có một số lý do quan trọng khiến chúng ta không nên luôn luôn sử dụng catch mà không có tham số:

                - Thiếu cụ thể và khó xử lý đúng lỗi
                - Bỏ sót lỗi logic
                - Làm giảm tính rõ ràng của mã nguồn
                - Bỏ sót các ngoại lệ nghiêm trọng
             */

            /*
             Câu 2:
               Việc tìm hiểu kỹ về các ngoại lệ và cách xử lý chúng là rất quan trọng trong lập trình vì các lý do sau:
                    
                    - Đảm bảo tính ổn định và an toàn của ứng dụng
                    - Tăng khả năng bảo trì và mở rộng mã nguồn
                    - Cải thiện trải nghiệm người dùng
                    - Quản lý tài nguyên hiệu quả hơn
                    - Tránh lỗi lan rộng

             */

            /*
              Câu 3:
               Trong lập trình, để xử lý ngoại lệ, các từ khóa sau thường được sử dụng:

                    1. try
                        Dùng để bao quanh một đoạn mã có khả năng phát sinh ngoại lệ. Nếu bất kỳ ngoại lệ nào xảy ra trong khối try,
                        chương trình sẽ chuyển sang khối catch tương ứng để xử lý.
                    2. catch
                        Dùng để bắt và xử lý các ngoại lệ. Bạn có thể có nhiều khối catch để xử lý các loại ngoại lệ khác nhau.

                    3. finally
                        Dùng để viết đoạn mã cần phải thực thi bất kể ngoại lệ có xảy ra hay không, chẳng hạn như đóng tài nguyên (tệp, kết nối cơ sở dữ liệu). 
                        Khối finally luôn được thực thi sau khi khối try và các khối catch đã hoàn tất
                    4. throw
                        Dùng để ném ra một ngoại lệ. Từ khóa này cho phép bạn tạo và ném một ngoại lệ, giúp truyền tải lỗi từ một phần của chương trình sang phần khác.
                    5. throws
                        Dùng trong khai báo phương thức để chỉ ra rằng phương thức đó có thể ném ra một hoặc nhiều ngoại lệ. Khi một phương thức khai báo throws,
                        các ngoại lệ này phải được xử lý bởi phương thức gọi nó hoặc tiếp tục được ném ra.
             */

            /*
             * Câu 4 :
                Lỗi (Error) và ngoại lệ (Exception) đều là những sự kiện bất thường có thể xảy ra trong quá trình thực thi chương trình, nhưng chúng có một số điểm khác biệt quan trọng:

                    - Lỗi là các vấn đề nghiêm trọng liên quan đến hệ thống hoặc tài nguyên, thường không thể xử lý được trong thời gian chạy.
                    - Ngoại lệ là các tình huống không bình thường trong chương trình mà lập trình viên có thể dự đoán và xử lý thông qua cơ chế try-catch.


             */

            /*
             Câu 5 :
                    Khi thực hiện việc bắt giữ các ngoại lệ, bạn nên bắt đầu từ chi tiết đến tổng quát. Điều này có nghĩa là các ngoại lệ cụ thể hơn (chi tiết hơn) nên được bắt trước, sau đó mới đến các ngoại lệ tổng quát hơn.

                    Lý do:
                        - Xử lý chính xác hơn: Khi bạn bắt các ngoại lệ chi tiết trước, bạn có thể thực hiện các biện pháp xử lý chính xác cho từng loại ngoại lệ cụ thể. Điều này giúp chương trình của bạn phản ứng một cách chính xác và phù hợp với từng tình huống lỗi cụ thể.

                        - Tránh bắt giữ quá mức: Nếu bạn bắt đầu bằng việc bắt ngoại lệ tổng quát (chẳng hạn như Exception trong Java), tất cả các ngoại lệ con sẽ bị bắt ở đó, và các khối catch chi tiết hơn sẽ không bao giờ được thực thi. 
                        Điều này có thể dẫn đến việc mất khả năng xử lý đặc biệt cho từng loại ngoại lệ.

                        - Tối ưu hóa mã nguồn: Bắt các ngoại lệ chi tiết trước giúp mã nguồn của bạn trở nên rõ ràng và dễ hiểu hơn, vì người đọc mã có thể thấy ngay cách mà mỗi loại lỗi cụ thể được xử lý.
             */

            /*
             Câu 6 : câu lệnh được dùng để phát sinh ngoại lệ là throw.
             */

            /*
             Câu 7 : 
                Dưới đây là cách phân biệt loại nào nên được xử lý bằng ngoại lệ và loại nào nên được xử lý bởi các mã lệnh thông thường:

                    - Mã lệnh thông thường: a, c (trong trường hợp có thể kiểm tra dễ dàng).
                    - Ngoại lệ: b, d (và c nếu kiểm tra không đảm bảo an toàn).

             */

            /*
             Câu 8 :

                Ngoại lệ phát sinh do nhiều nguyên nhân khác nhau trong quá trình thực thi chương trình. Dưới đây là một số nguyên nhân phổ biến:

                    - Lỗi chia cho số không 
                    - Lỗi nhập sai ñịnh dạng dữ liệu 
                    - Lỗi truy xuất vượt quá phạm vi của mảng 
                    - Lỗi tràn bộ nhớ
                    - Lỗi thiếu bộ nhớ
                    - …
             */
            /*
             Câu 9 :
                Ngoại lệ xuất hiện chủ yếu trong khi thực thi chương trình
             */

            /*
             * Câu 10 :
                 Khối lệnh trong finally được thực hiện bất kể có xảy ra ngoại lệ hay không trong khối try. 
                Điều này có nghĩa là mã trong khối finally sẽ luôn được thực thi sau khi khối try và bất kỳ khối catch (nếu có) đã hoàn tất.
             */

            /*
             Câu 11 :

                 các lớp liên quan đến việc xử lý ngoại lệ nằm trong namespace System. 
                 Đây là namespace chứa tất cả các lớp cơ bản và các lớp xử lý lỗi quan trọng trong .NET Framework.
             */

            // Câu 12     
               try
        {
            // Giả định Sothu1 và Sothu2 là các biến số nguyên
            int Sothu1 = 10;
            int Sothu2 = 0;
            int Ketqua;

            Ketqua = Sothu1 / Sothu2; 

            Console.WriteLine("Kết quả là: " + Ketqua);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Lỗi: Không thể chia cho 0. " + e.Message);
        }
        finally
        {
            Console.WriteLine("Chương trình đã kết thúc.");
        }

            //

            //Câu 13 :

            /*
             using System;
                using System.IO;

                public class Tester
                {
                    public static void Main()
                    {
                        string fname = "test3.txt";
                        string buffer;

                        try
                        {
                      
                            StreamReader sReader = File.OpenText(fname);
            
                      
                            while ((buffer = sReader.ReadLine()) != null)
                            {
                                Console.WriteLine(buffer);
                            }
                            sReader.Close();
                        }
                        catch (FileNotFoundException e)
                        {
                            Console.WriteLine("Lỗi: Tập tin không tồn tại. " + e.Message);
                        }
                        catch (UnauthorizedAccessException e)
                        {
                            Console.WriteLine("Lỗi: Không có quyền truy cập tập tin. " + e.Message);
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("Lỗi: Xảy ra lỗi trong quá trình đọc tập tin. " + e.Message);
                        }
                        catch (Exception e)
                        {
                            // Bắt tất cả các ngoại lệ khác
                            Console.WriteLine("Lỗi không xác định: " + e.Message);
                        }
                        finally
                        {
                            Console.WriteLine("Chương trình đã kết thúc.");
                        }
                    }
                }
             */
        }
    }
}
