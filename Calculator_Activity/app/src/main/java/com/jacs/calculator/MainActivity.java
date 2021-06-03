package com.jacs.calculator;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.text.SpannableStringBuilder;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import org.mariuszgromada.math.mxparser.*;

public class MainActivity extends AppCompatActivity {

    private TextView previousCalculation;
    private EditText display;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        previousCalculation = findViewById(R.id.previousCalculationView);
        display = findViewById(R.id.displayEditText);

        display.setShowSoftInputOnFocus(false);
    }

    private void updateText(String strToAdd)
    {
        String oldStr = display.getText().toString();

        int cursorPos = display.getSelectionStart();
        String leftStr = oldStr.substring(0, cursorPos);
        String rightStr = oldStr.substring(cursorPos);

        display.setText(String.format("%s%s%s", leftStr, strToAdd, rightStr));
        display.setSelection(cursorPos + strToAdd.length());
    }

    public void zeroBtnPush(View view)
    {
        updateText(getResources().getString(R.string.zeroText));
    }

    public void oneBtnPush(View view)
    {
        updateText(getResources().getString(R.string.oneText));
    }

    public void twoBtnPush(View view)
    {
        updateText(getResources().getString(R.string.twoText));
    }

    public void threeBtnPush(View view)
    {
        updateText(getResources().getString(R.string.threeText));
    }

    public void fourBtnPush(View view)
    {
        updateText(getResources().getString(R.string.fourText));
    }

    public void fiveBtnPush(View view)
    {
        updateText(getResources().getString(R.string.fiveText));
    }

    public void sixBtnPush(View view)
    {
        updateText(getResources().getString(R.string.sixText));
    }

    public void sevenBtnPush(View view)
    {
        updateText(getResources().getString(R.string.sevenText));
    }

    public void eightBtnPush(View view)
    {
        updateText(getResources().getString(R.string.eightText));
    }

    public void ninePush(View view)
    {
        updateText(getResources().getString(R.string.nineText));
    }

    public void multiplyBtnPush(View view)
    {
        updateText(getResources().getString(R.string.multiplyText));
    }

    public void divideBtnPush(View view)
    {
        updateText(getResources().getString(R.string.divideText));
    }

    public void addBtnPush(View view)
    {
        updateText(getResources().getString(R.string.addText));
    }

    public void subtractBtnPush(View view)
    {
        updateText(getResources().getString(R.string.subtractText));
    }

    public void clearBtnPush(View view)
    {
        display.setText("");
        previousCalculation.setText("");
    }

    public void parOpenBtnPush(View view)
    {
        updateText(getResources().getString(R.string.parenthesesOpenText));
    }

    public void parCloseBtnPush(View view)
    {
        updateText(getResources().getString(R.string.parenthesesCloseText));
    }

    public void decimalBtnPush(View view)
    {
        updateText(getResources().getString(R.string.decimalText));
    }

    public void equalBtnPush(View view)
    {
        String userExp = display.getText().toString();

        previousCalculation.setText(userExp);

        userExp = userExp.replaceAll(getResources().getString(R.string.divideText), "/");
        userExp = userExp.replaceAll(getResources().getString(R.string.multiplyText), "*");

        Expression exp = new Expression(userExp);
        String result = String.valueOf(exp.calculate());

        display.setText(result);
        display.setSelection(result.length());
    }

    public void backspaceBtnPush(View view)
    {
        int cursorPos = display.getSelectionStart();
        int textLen = display.getText().length();

        if (cursorPos != 0 && textLen != 0)
        {
            SpannableStringBuilder selection = (SpannableStringBuilder) display.getText();
            selection.replace(cursorPos - 1, cursorPos, "");
            display.setText(selection);
            display.setSelection(cursorPos - 1);
        }
    }

    public void trigSinBtnPush(View view)
    {
        updateText("sin(");
    }

    public void trigCosBtnPush(View view)
    {
        updateText("cos(");
    }

    public void trigTanBtnPush(View view)
    {
        updateText("tan(");
    }

    public void trigArcsinBtnPush(View view)
    {
        updateText("arcsin(");
    }

    public void trigArccosBtnPush(View view)
    {
        updateText("arccos(");
    }

    public void trigArctanBtnPush(View view)
    {
        updateText("arctan(");
    }

    public void logBtnPush(View view)
    {
        updateText("log(");
    }

    public void lnBtnPush(View view)
    {
        updateText("ln(");
    }

    public void sqrrootBtnPush(View view)
    {
        updateText("sqrt(");
    }

    public void eBtnPush(View view)
    {
        updateText("e(");
    }

    public void piBtnPush(View view)
    {
        updateText("pi(");
    }

    public void absoluteBtnPush(View view)
    {
        updateText("abs(");
    }

    public void primeBtnPush(View view)
    {
        updateText("ispr(");
    }

    public void sqrBtnPush(View view)
    {
        updateText("^(2)");
    }

    public void powerBtnPush(View view)
    {
        updateText("^(");
    }
}