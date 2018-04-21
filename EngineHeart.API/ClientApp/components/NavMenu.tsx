import * as React from 'react';
import {Button, Icon, Menu} from "semantic-ui-react";

export class NavMenu extends React.Component<{}, {}> {

    private static async onClickHandler() {
        let body = JSON.stringify({});
        await fetch(`/api/robots`, {
            method: 'POST',
            headers: {
                'content-type': 'application/json'
            },
            body: body,
        });
        window.location.reload();
    }

    public render() {
        return <Menu fixed='left' inverted vertical borderless size='massive'>
            <Menu.Item header>Engine Heart</Menu.Item>
            <Menu.Item link as='a' href='/'>Home</Menu.Item>
            <Menu.Item link as='a' href='/robots'>Robots</Menu.Item>
            <Menu.Item link onClick={NavMenu.onClickHandler.bind(this)}><Icon name='plus'/>Create New Robot</Menu.Item>
        </Menu>;
    }
}
