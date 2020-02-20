protected override void OnKeyDown(KeyEventArgs e)
{
    switch (e.KeyCode)
    {
        case Keys.Right:
        case Keys.Left:
        case Keys.Up:
        case Keys.Down:
            this.HandleMoveResizeKeystroke(e);
            break;

        case Keys.Space:
            this.ChangeOrientation();
            break;

        case Keys.ControlKey | Keys.S:
            SetSizeHandler(this, EventArgs.Empty);
            break;
        case Key.Plus | Key.Minus:
            this.HandleOpacity(e);
            break;
    }

    base.OnKeyDown(e);
}

private void HandleOpacity(KeyEventArgs e)
{
    if (e.Keycode == Key.Plus)
    {
        rulerInfo.opacity * 100;
    }
    else
    {
        rulerInfo.opacity / 100;
    }
}