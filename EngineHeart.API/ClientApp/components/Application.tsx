import * as React from 'react';
import { NavMenu } from './NavMenu';

export interface ApplicationProps {
    children?: React.ReactNode;
}

export class Application extends React.Component<ApplicationProps, {}> {
    public render() {
        return <div>
                <div style={{width: "250px"}}>
                    <NavMenu />
                </div>
                <div style={{marginLeft: "250px", minWidth: "550px", maxWidth: "1150px"}}>
                    { this.props.children }
                </div>
        </div>;
    }
}
