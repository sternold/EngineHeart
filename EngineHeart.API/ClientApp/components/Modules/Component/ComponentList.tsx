import * as React from 'react';
import {Table} from 'semantic-ui-react';
import './Component.css';

interface ComponentListProps {
    header: string,
}

export class ComponentList extends React.Component<ComponentListProps, {}> {

    public render() {
        const {header} = this.props;
        return <div className='component-container-child'>
            <h3>{header}</h3>
            <Table padded celled size='large'>
                <Table.Header>
                    <Table.Row>
                        <Table.HeaderCell>Name</Table.HeaderCell>
                        <Table.HeaderCell>Rating</Table.HeaderCell>
                    </Table.Row>
                </Table.Header>
                <Table.Body>
                {this.props.children}
                </Table.Body>
            </Table>
        </div>;
    }
}
