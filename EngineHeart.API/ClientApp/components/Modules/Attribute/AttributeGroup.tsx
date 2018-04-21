import * as React from 'react';
import {Card, List} from 'semantic-ui-react';

interface AttributeGroupProps {
    header: string,
}

export class AttributeGroup extends React.Component<AttributeGroupProps, {}> {

    public render() {
        const {children, header} = this.props;
        return <Card>
            <Card.Content>
                <Card.Header>{header}</Card.Header>
                <List>
                    {children ? (children as React.Component[]).map((child) => {
                        return <List.Item>{child}</List.Item>;
                    }) : false}
                </List>
            </Card.Content>
        </Card>;
    }
}
