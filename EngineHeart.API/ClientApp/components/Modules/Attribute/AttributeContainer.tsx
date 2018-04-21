import * as React from 'react';
import {Card} from 'semantic-ui-react';

export class AttributeContainer extends React.Component<{}, {}> {

    public render() {
        return <Card.Group itemsPerRow={3}>
            {this.props.children}
        </Card.Group>;
    }
}
