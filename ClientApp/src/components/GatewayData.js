import React, { Component } from 'react';

export class GatewayData extends Component {
    static displayName = GatewayData.name;

    constructor(props) {
        super(props);
        this.state = { gateways: [], loading: true };
    }

    componentDidMount() {
        this.populateGateWayData();
    }

    static renderGatewaysTable(gateways) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Mac</th>                       
                        <th>Name</th>
                        <th>Location</th>                        
                    </tr>
                </thead>
                <tbody>
                    {gateways.map(gateway =>
                        <tr key={gateway.id}>
                            <td>{gateway.id}</td>
                            <td>{gateway.mac}</td>
                            <td>{gateway.name}</td>
                            <td>{gateway.location}</td>                            
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : GatewayData.renderGatewaysTable(this.state.gateways);

        return (
            <div>
                <h1 id="tabelLabel" >Gateway Table</h1>
                <p>This component demonstrates fetching data from the gateway.</p>
                {contents}
            </div>
        );
    }

    async populateGateWayData() {
        const response = await fetch('gateway');
        const data = await response.json();
        this.setState({ gateways: data, loading: false });
    }
}
