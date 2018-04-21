import * as React from 'react';
import './Component.css';

export class ComponentContainer extends React.Component<{}, {}> {

    public render() {
        return <div className={'component-container'}>
            {this.props.children}
        </div>;
    }
}
