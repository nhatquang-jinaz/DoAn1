CREATE TABLE NguoiDung (
    maND VARCHAR(20) PRIMARY KEY,
    hoTen NVARCHAR(100) NOT NULL,
    tenDN NVARCHAR(50) NOT NULL UNIQUE,
    matKhau NVARCHAR(255) NOT NULL,
    email VARCHAR(100) UNIQUE,
    SDT VARCHAR(10),

    vaiTro NVARCHAR(20) NOT NULL
    CHECK (vaiTro IN (N'Quản lý', N'Nhân viên')),

    phongBan NVARCHAR(100),
    chucVu NVARCHAR(100),

    ngayTao DATETIME DEFAULT GETDATE(),
    trangThai BIT DEFAULT 1
);
CREATE TABLE DuAn (
    maDA VARCHAR(20) PRIMARY KEY,
    tenDA NVARCHAR(200) NOT NULL,
    moTa NVARCHAR(500),

    ngayBatDau DATETIME NOT NULL,
    ngayKT DATETIME,

    trangThai NVARCHAR(30)
    DEFAULT N'Đang thực hiện'
    CHECK (
        trangThai IN (
            N'Chưa thực hiện',
            N'Đang thực hiện',
            N'Hoàn thành'
        )
    ),

    maQuanLy VARCHAR(20) NOT NULL,

    ngayTao DATETIME DEFAULT GETDATE(),
    ngayCapNhat DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (maQuanLy)
    REFERENCES NguoiDung(maND)
);
CREATE TABLE CongViec (
    maCV VARCHAR(20) PRIMARY KEY,
    tenCV NVARCHAR(200) NOT NULL,
    moTa NVARCHAR(500),

    thoiHan DATETIME,

    doUuTien NVARCHAR(20)
    DEFAULT N'Bình thường'
    CHECK (
        doUuTien IN (
            N'Bình thường',
            N'Gấp',
            N'Rất gấp'
        )
    ),

    trangThai NVARCHAR(30)
    DEFAULT N'Chưa thực hiện'
    CHECK (
        trangThai IN (
            N'Chưa thực hiện',
            N'Đang thực hiện',
            N'Hoàn thành'
        )
    ),

    ptramHoanThanh INT DEFAULT 0
    CHECK (ptramHoanThanh BETWEEN 0 AND 100),

    maDA VARCHAR(20) NOT NULL,
    nguoiTao VARCHAR(20) NOT NULL,

    ngayTao DATETIME DEFAULT GETDATE(),
    ngayCapNhat DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (maDA)
    REFERENCES DuAn(maDA)
    ON DELETE CASCADE,

    FOREIGN KEY (nguoiTao)
    REFERENCES NguoiDung(maND)
);
CREATE TABLE PhanCong (
    maCV VARCHAR(20) NOT NULL,
    maNV VARCHAR(20) NOT NULL,

    ngayPhanCong DATETIME DEFAULT GETDATE(),

    PRIMARY KEY (maCV, maNV),

    FOREIGN KEY (maCV)
    REFERENCES CongViec(maCV)
    ON DELETE CASCADE,

    FOREIGN KEY (maNV)
    REFERENCES NguoiDung(maND)
);
CREATE TABLE TienDo (
    maTD VARCHAR(20) PRIMARY KEY,

    maCV VARCHAR(20) NOT NULL,

    ptramHoanThanh INT NOT NULL
    CHECK (ptramHoanThanh BETWEEN 0 AND 100),

    ghiChu NVARCHAR(500),

    ngayCapNhat DATETIME DEFAULT GETDATE(),

    nguoiCapNhat VARCHAR(20) NOT NULL,

    FOREIGN KEY (maCV)
    REFERENCES CongViec(maCV)
    ON DELETE CASCADE,

    FOREIGN KEY (nguoiCapNhat)
    REFERENCES NguoiDung(maND)
);

--thêm dữ liệu
INSERT INTO NguoiDung(maND, hoTen, tenDN, matKhau, email, SDT, vaiTro, phongBan, chucVu) VALUES
('ND01', N'Quang', 'quang', '123456', 'quang@gmail.com', '0900000001', N'Quản lý', N'CNTT', N'Trưởng nhóm'),
('ND02', N'Huy', 'huy', '299229', 'huy@gmail.com', '0300000002', N'Nhân viên', N'CNTT', N'Lập trình viên'),
('ND03', N'Toàn', 'toan', '898989', 'toan@gmail.com', '0900000003', N'Nhân viên', N'CNTT', N'Tester'),
('ND04', N'Phong', 'phong', '123123', 'phong@gmail.com', '0300000004', N'Nhân viên', N'Marketing', N'Lập trình viên'),
('ND05', N'Vy', 'vy', '456456', 'vy@gmail.com', '0900000005', N'Nhân viên', N'Thiết kế', N'Designer');

INSERT INTO DuAn(maDA, tenDA, moTa, ngayBatDau, ngayKT, trangThai, maQuanLy) VALUES
('DA01', N'Hệ thống quản lý công việc', N'Quản lý công việc theo dự án', '2026-05-01', '2026-06-01', N'Đang thực hiện', 'ND01'),
('DA02', N'Website bán hàng', N'Xây dựng website thương mại điện tử', '2026-05-05', '2026-07-01', N'Chưa thực hiện', 'ND01'),
('DA03', N'Ứng dụng quản lý thư viện', N'Quản lý sách thư viện', '2026-04-01', '2026-05-20', N'Hoàn thành', 'ND01'),
('DA04', N'Ứng dụng học online', N'Hệ thống học trực tuyến', '2026-05-10', '2026-08-01', N'Đang thực hiện', 'ND01'),
('DA05', N'Website tin tức', N'Trang web cập nhật tin tức', '2026-06-01', '2026-09-01', N'Chưa thực hiện', 'ND01');


INSERT INTO CongViec(maCV, tenCV, moTa, thoiHan, doUuTien, trangThai, ptramHoanThanh, maDA, nguoiTao) VALUES
('CV01', N'Thiết kế giao diện', N'Tạo giao diện đăng nhập', '2026-05-10', N'Gấp', N'Đang thực hiện', 50, 'DA01', 'ND01'),
('CV02', N'Tạo cơ sở dữ liệu', N'Thiết kế database SQL Server', '2026-05-15', N'Rất gấp', N'Chưa thực hiện', 0, 'DA01', 'ND01'),
('CV03', N'Kiểm thử hệ thống', N'Test chức năng quản lý công việc', '2026-05-18', N'Bình thường', N'Hoàn thành', 100, 'DA03', 'ND01'),
('CV04', N'Thiết kế logo', N'Tạo logo cho website', '2026-06-01', N'Bình thường', N'Đang thực hiện', 40, 'DA02', 'ND01'),
('CV05', N'Xây dựng API', N'Lập trình backend API', '2026-06-10', N'Rất gấp', N'Chưa thực hiện', 0, 'DA04', 'ND01');

INSERT INTO PhanCong(maCV, maNV) VALUES
('CV01', 'ND02'),
('CV02', 'ND02'),
('CV03', 'ND03'),
('CV04', 'ND05'),
('CV05', 'ND04');

INSERT INTO TienDo(maTD, maCV, ptramHoanThanh, ghiChu, nguoiCapNhat) VALUES
('TD01', 'CV01', 30, N'Hoàn thành giao diện cơ bản', 'ND02'),
('TD02', 'CV02', 50, N'Đã thiết kế cơ bản CSDL', 'ND02'),
('TD03', 'CV03', 100, N'Đã hoàn thành kiểm thử', 'ND03'),
('TD04', 'CV04', 40, N'Đang hoàn thiện màu sắc logo', 'ND05'),
('TD05', 'CV05', 10, N'Đã xây dựng API đăng nhập', 'ND04');