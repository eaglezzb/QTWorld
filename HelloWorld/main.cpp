#include <QApplication>
#include <QDialog>
#include <QLabel>
#include <QTextCodec>
int main(int argc, char* argv[])
{
    QApplication App(argc, argv);
    QTextCodec::setCodecForTr(QTextCodec::codecForLocale());
    QDialog mainWnd;
    mainWnd.resize(800, 600);
    QLabel label(&mainWnd);
    label.move(0, 300);
    label.setText(QObject::tr("Hi QT, 我是中国字"));
    mainWnd.show();
    return App.exec();
}
