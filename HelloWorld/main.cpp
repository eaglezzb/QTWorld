#include <QApplication>
#include <QDialog>
#include <QLabel>

int main(int argc, char* argv[])
{
    QApplication App(argc, argv);
    QDialog mainWnd;
    QLabel label(&mainWnd);
    label.setText("Hi QT, 我是中国字");
    mainWnd.show();
    return App.exec();
}
