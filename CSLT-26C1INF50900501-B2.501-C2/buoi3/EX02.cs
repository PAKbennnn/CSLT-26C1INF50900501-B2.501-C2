using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
namespace CSLT_26C1INF50900501_B2._501_C2.buoi3
{
    internal class Ex02
    {

        static void Bai_1()
        {
            Console.Write("Nhập chỉ số điện cũ (kWh):");
            float csd_cu = Convert.ToSingle(Console.ReadLine());
            float csd_moi;
            do
            {
                Console.Write("Nhập chỉ số điện mới (kWh):");
                csd_moi = Convert.ToSingle(Console.ReadLine());
                if (csd_moi >= csd_cu)
                    break;
                else
                    Console.WriteLine("\t*** CHỉ số mới phải lớn hơn hoặc bằng chỉ số cũ.");
            } while (true);

            //Tính lượng điện tiêu thụ trong tháng = Chỉ số mới - Chỉ số cũ.
            float tieuThu = csd_moi - csd_cu;
            //Giả sử đon giá cố định 1 chữ là 3059 đồng /1 kWh
            float dongia = 3059f;

            decimal tienDien = (decimal)(tieuThu * dongia);//cast

            //thuế VAT
            decimal vat = (decimal)(tieuThu * 0.08f);

            //in ra hóa đơn
            Console.WriteLine($"\nSố điện tiêu thụ: {tieuThu} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDien:C}");
            Console.WriteLine($"Thuế VAT (8%): {vat:C}");
            Console.WriteLine($"Tổng thanh toán: {tienDien + vat:C}");
        }
        static void Bai_2()
        {
            Console.WriteLine("Chiều cao (m) : ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cân nặng (kg): ");
            double w = Convert.ToDouble(Console.ReadLine());
            double bmi = w / Math.Pow(h, 2);
            Console.WriteLine($"Chỉ số BMI của bạn là : {bmi:F2}");
            if (bmi < 18.5)
            {
                Console.WriteLine("Phân loại sức khỏe : gầy (thiếu cân) ");
            }
            else if (bmi >= 18.5 && bmi < 23.0)
            {
                Console.WriteLine("Phân loại sức khỏe : bình thường (lý tưởng)");
            }
            else if (bmi >= 23.0 && bmi < 25.0)
            {
                Console.WriteLine("Phân loại sức khỏe : thừa cân");
            }
            else if (bmi >= 25.0)
            {
                Console.WriteLine("Phân loại sức khỏe : béo phì");
            }
            double wmin = 18.5 * Math.Pow(h, 2);
            double wmax = 22.9 * Math.Pow(h, 2);
            Console.WriteLine($"Cân nặng lý tưởng nên từ {wmin:F2} đến {wmax:F2}");

        }
        static void Bai_3()
        {
            Console.WriteLine(" VND : ");
            decimal vnd = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            string cy = Convert.ToString(Console.ReadLine());

            decimal fee = (decimal)vnd * (decimal)0.005;
            Console.WriteLine($"FEE : {fee}");
            decimal vndaf = vnd - fee;

            if (cy == "1")
            {
                decimal usd = vndaf / 25400;
                Console.WriteLine($"USD : {usd}");
            }
            else if (cy == "2")
            {
                decimal eur = vndaf / 27200;
                Console.WriteLine($"EUR : {eur}");
            }
            else if (cy == "3")
            {
                decimal jpy = vndaf / 165;
                Console.WriteLine($"JPY : {jpy}");
            }
            else if (cy == "4")
            {
                decimal gbp = vndaf / 32100;
                Console.WriteLine($"GBP :{gbp}");
            }
            else
            {
                Console.WriteLine("unavailable");
            }


        }
        static void Bai_4()
        {
            Console.WriteLine("Nhập ngày sinh (dd/MM/yyyy): ");
            string input = Console.ReadLine();


            bool isValid = DateTime.TryParseExact(
                input,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime birthDate
            );

            if (!isValid)
            {
                Console.WriteLine("Ngày sinh không đúng định dạng dd/MM/yyyy!");
                return;
            }


            DateTime today = DateTime.Now.Date;


            int age = today.Year - birthDate.Year;

            if (today.Month < birthDate.Month ||
                (today.Month == birthDate.Month && today.Day < birthDate.Day))
            {
                age--;
            }


            TimeSpan livedSpan = today - birthDate;
            int totalDaysLived = livedSpan.Days;

            DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);
            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }


            TimeSpan remainingSpan = nextBirthday - today;
            int daysUntilNextBirthday = remainingSpan.Days;

            Console.WriteLine($"Tuổi hiện tại: {age}");
            Console.WriteLine($"Tổng số ngày đã sống: {totalDaysLived} ngày");
            Console.WriteLine($"Số ngày còn lại đến sinh nhật kế tiếp: {daysUntilNextBirthday} ngày");
        }
        static void bai_5()
        {
            Console.WriteLine("Điểm môn C# là: ");
            double m1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Số tín chỉ C# là: ");
            double stcm1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Điểm môn Toán là: ");
            double m2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Số tín chỉ Toán là: ");
            double stcm2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Điểm môn Tiếng Anh là: ");
            double m3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Số tín chỉ Tiếng Anh là: ");
            double stcm3 = Convert.ToDouble(Console.ReadLine());

            double diemtb = (m1 * stcm1 + m2 * stcm2 + m3 * stcm3) / (stcm1 + stcm2 + stcm3);
            Console.WriteLine($"Điểm trung bình theo thang 10 : {diemtb}");
            if (diemtb >= 8.5)
            {
                Console.WriteLine("Điểm chữ quy đổi : A");
                Console.WriteLine("Điểm GPA thang 4 : 4.0");
                Console.WriteLine("Xếp loại học lực : Giỏi");
            }
            else if (diemtb >= 7.0 && diemtb < 8.5)
            {
                Console.WriteLine("Điểm chữ quy đổi : B");
                Console.WriteLine("Điểm GPA thang 4 : 3.0");
                Console.WriteLine("Xếp loại học lực : Khá");
            }
            else if (diemtb >= 5.5 && diemtb < 7.0)
            {
                Console.WriteLine("Điểm chữ quy đổi :C");
                Console.WriteLine("Điểm GPA thang 4 : 2.0");
                Console.WriteLine("Xếp loại học lực : Trung bình ");
            }
            else if (diemtb >= 4.0 && diemtb < 5.5)
            {
                Console.WriteLine("Điểm chữ quy đổi : D");
                Console.WriteLine("Điểm GPA thang 4 : 1.0");
                Console.WriteLine("Xếp loại học lực : Yếu");
            }
            else if (diemtb < 4.0)
            {
                Console.WriteLine("Điểm chữ quy đổi : F");
                Console.WriteLine("Điểm GPA thang 4 : 0.0");
                Console.WriteLine("Xếp loại học lực : Kém");
            }



        }
        static void bai_6()
        {

            Console.WriteLine("Nhập họ và tên :");
            string raw = Convert.ToString(Console.ReadLine());
            string clean = CleanSpaces(raw);
            string title = ToTitleCase(clean);


            string[] parts = title.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string ho = parts[0];
            string ten = parts[parts.Length - 1];
            string tenDem = string.Join(" ", parts, 1, parts.Length - 2);

            string tenNoAccent = RemoveDiacritics(ten).ToLower();
            string hoTenDemNoAccent = RemoveDiacritics(ho + tenDem).ToLower();
            string username = $"{tenNoAccent}.{hoTenDemNoAccent}";

            string email = $"{username}@company.edu.vn";

            Console.WriteLine($"Họ tên chuẩn hóa: {title}");
            Console.WriteLine($"Họ: {ho} | Tên đệm: {tenDem} | Tên: {ten}");
            Console.WriteLine($"Username tạo tự động: {username}");
            Console.WriteLine($"Email cấp phát: {email}");


            static string CleanSpaces(string input)
            {
                string[] words = input.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                return string.Join(" ", words);
            }


            static string ToTitleCase(string input)
            {
                string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i].ToLower();
                    words[i] = char.ToUpper(word[0]) + word.Substring(1);
                }
                return string.Join(" ", words);
            }


            static string RemoveDiacritics(string input)
            {
                string normalized = input.Normalize(NormalizationForm.FormD);
                StringBuilder sb = new StringBuilder();

                foreach (char c in normalized)
                {
                    UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(c);
                    if (category != UnicodeCategory.NonSpacingMark)
                    {
                        sb.Append(c);
                    }
                }

                string result = sb.ToString().Normalize(NormalizationForm.FormC);
                result = result.Replace('đ', 'd').Replace('Đ', 'D');
                return result;

            }
        }
        static void bai_7()
        {
            Console.WriteLine("Quãng đường :");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhiên liệu tiêu thụ (l/100km)");
            double lpkm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Giá xăng :");
            double pr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Số người đi");
            double ps = Convert.ToDouble(Console.ReadLine());
            double l = s / 100 * lpkm;
            decimal spr = (decimal)pr * (decimal)l;
            decimal epr = spr / (decimal)ps;

            Console.WriteLine($"Tổng nhiên liệu tiêu thụ : {l} l ");
            Console.WriteLine($"Tổng chi phí xăng dầu:{spr} VND ");
            Console.WriteLine($"Chi phí trên đầu người là:{epr} VND ");



        }
        static void bai_8()
        {
            string otpreal = "123456";
            DateTime timer = DateTime.Now;
            Console.WriteLine("OTP nhận được là :");
            string otpin = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Thời gian trôi qua (phút): ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Thời gian trôi qua (giây): ");
            int sec = int.Parse(Console.ReadLine());

            DateTime verifyTime = timer.AddMinutes(min).AddSeconds(sec);

            string result = VerifyOtp(otpin, otpreal, timer, verifyTime);

            
            Console.WriteLine($"Trạng thái xác thực: {result}");

            static string VerifyOtp(string otpin, string otpreal, DateTime timer, DateTime verifyTime)
        {

            if (otpin.Length != 6 || !int.TryParse(otpin, out _))
            {
                return "LỖI - Định dạng không hợp lệ (phải đủ 6 số).";
            }

            // ĐIỀU KIỆN 3: Kiểm tra thời gian hết hạn (kiểm tra trước hay sau đều được,
            // nhưng đề yêu cầu in đúng loại lỗi nên kiểm tra theo thứ tự ưu tiên hợp lý)
            TimeSpan elapsed = verifyTime - timer;
            if (elapsed.TotalSeconds > 300)
            {
                return "LỖI - Mã OTP đã hết hạn (vượt quá 5 phút).";
            }

            // ĐIỀU KIỆN 2: So sánh mã OTP nhập vào với mã hệ thống
            if (otpin != otpreal)
            {
                return "LỖI - Mã OTP không đúng.";
            }

            // Tất cả điều kiện đều thỏa mãn
            return "THÀNH CÔNG - Giao dịch đã được phê duyệt.";
        }







    }
        static void bai_9()
        {
            Console.WriteLine("Lương Gross : ");
            decimal gross = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Số người phụ thuộc : ");
            int nguoi = int.Parse(Console.ReadLine());

            decimal bh = gross * (decimal)0.105;

            decimal tncn = 0;

            if (gross >0 && gross <=5000000)
            {
                 tncn = gross * (decimal)0.05;
            }
            else if(gross > 5000000 && gross <= 10000000)
            {
                tncn = gross * (decimal)0.1;
            }
            else if (gross > 10000000 && gross <= 18000000)
            {
                tncn = gross * (decimal)0.15;
            }
            else if (gross > 18000000 )
            {
                 tncn = gross * (decimal)0.2;
            }
            else
            {
                 tncn = 0;
            }
            decimal thct = 0;
            if (gross > 0 )
            {
                thct = gross - bh - (decimal)11000000- tncn;
            }
            else 
            {
                thct = 0;
            }
            decimal net = gross - tncn - bh;
            Console.WriteLine($"Giảm trừ bảo hiểm: {bh}");
            Console.WriteLine($"Thu nhập chịu thuế : {thct}");
            Console.WriteLine($"Thuế TNCN phải nộp: {tncn}");
            Console.WriteLine($"LƯƠNG NET THỰC NHẬN:{net}");


        }
        static void bai_11()
        {
           
        Console.WriteLine("Số tiền gửi: ");
            decimal P = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Lãi suất năm (%/năm): ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kỳ hạn gửi (tháng): ");
            int n = Convert.ToInt32(Console.ReadLine());

            
            decimal simpleInterest = P * (decimal)(r / 100) * (decimal)(n / 12.0);

           
            double base_ = 1 + (r / 100) / 12;
            double totalCompoundDouble = (double)P * Math.Pow(base_, n);
            decimal totalCompound = (decimal)totalCompoundDouble;
            decimal compoundInterest = totalCompound - P;

          
            decimal difference = compoundInterest - simpleInterest;
            string betterMethod = difference >= 0 ? "Lãi kép tối ưu hơn" : "Lãi đơn tối ưu hơn";

            Console.WriteLine();
            Console.WriteLine($"Tổng tiền lãi (Lãi đơn): {simpleInterest:N0} VNĐ");
            Console.WriteLine($"Tổng tiền lãi (Lãi kép): {compoundInterest:N0} VNĐ");
            Console.WriteLine($"Lợi nhuận chênh lệch: {Math.Abs(difference):N0} VNĐ ({betterMethod})");
        }
        static void bai_10()
        {

        }

        public static void Main0(string[] args)
        {
            

            Bai_1();
            Bai_2();
            Bai_3();
            Bai_4();
            bai_5();
            bai_6();
            bai_7();
            bai_8();
            bai_9();
            bai_10();
            bai_11();
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("\nNhấn phím bất kỳ để kết thúc");
            Console.ReadKey();

        }
    }
}